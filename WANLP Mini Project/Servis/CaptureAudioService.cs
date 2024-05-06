namespace WANLP_Mini_Project.Servis
{
    public class CaptureAudioService : IDisposable
    {
        int _device, _handle;
        byte[]? _buffer;
        public static List<byte> audio_capture = new List<byte>();

        public string errors="";
        bool capturing = false;

        public CaptureAudioService(int Device)
        {
            Bass.Init();
            _device = Device;
        }

        public bool Procedure(int Handle, IntPtr Buffer, int Length, IntPtr User)
        {
            if (capturing)
            {
                _buffer = new byte[Length];

                Marshal.Copy(Buffer, _buffer, 0, Length);
                audio_capture.AddRange(_buffer);

                DataAvailable?.Invoke(_buffer, Length);
            }
            else
            {
                _buffer = null;
            }
            return true;
        }


        public event DataAvailableHandler DataAvailable;
        public delegate void DataAvailableHandler(byte[] Buffer, int Length);

        public void Start()
        {
            if (Bass.Init())
            {
                errors += "Error initializing BASS";
            }
            if (Bass.RecordInit(_device))
            {
                errors += "Error initializing recording";
            }
            _handle = Bass.RecordStart(44100, 1, BassFlags.Mono, Procedure);
            Bass.ChannelPlay(_handle);
            capturing = true;
        }

        public void Stop()
        {
            capturing = false;
            Bass.RecordFree();
        }

        public void Dispose()
        {
            Bass.CurrentRecordingDevice = _device;
            Bass.RecordFree();
        }


        public float Calculer_volume(byte[] buffer, int length)
        {
            short[] shortBuffer = new short[length / 2];
            Buffer.BlockCopy(buffer, 0, shortBuffer, 0, length);

            float rms = 0;
            for (int i = 0; i < shortBuffer.Length; i++)
            {
                rms += shortBuffer[i] * shortBuffer[i];
            }
            rms = (float)Math.Sqrt(rms / shortBuffer.Length);


            return rms;
        }

        int numero_audio = 0;
        public void jouer_music(byte[] audio)
        {
            int streamHandle = Bass.CreateStream(audio, 0, audio.Length, BassFlags.Byte);
            //Bass.Init();
            if(numero_audio != 0)
            {
                Bass.StreamFree(numero_audio);
            }
            if (streamHandle != 0)
            {
                Bass.ChannelPlay(streamHandle, false);
                numero_audio = streamHandle;
            }
            else
            {
                Debug.WriteLine(streamHandle);
            }

        }
    }

    public class RecordingDevice : IDisposable
    {
        public string Name { get; set; }

        public int Index { get; }

        RecordingDevice(int Index, string Name)
        {
            this.Index = Index;

            this.Name = Name;
        }

        public static IEnumerable<RecordingDevice> Enumerate()
        {
            for (int i = 0; Bass.RecordGetDeviceInfo(i, out var info); ++i)
                yield return new RecordingDevice(i, info.Name);
        }

        public void Dispose()
        {
            Bass.CurrentRecordingDevice = Index;
            Bass.RecordFree();
        }

        public override string ToString() => Name;
    }
}
