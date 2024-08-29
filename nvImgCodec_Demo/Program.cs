using System;
using System.Numerics;
using System.Text;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Runtime.CompilerServices;

namespace NvImgCodec
{
    class Program
    {
        static void Main(string[] args)
        {
            //var nvImgCodecInstance = Initialize();
            string imagePath = "D:/nvImageCodecTest/test.jpg";
            TestReadImageFromFile(imagePath);
        }

        public static NvImgCodecInstance Initialize()
        {
            NvImgCodecInstance instance = new NvImgCodecInstance();
            NvImgCodecInstanceCreateInfo createInfo = new NvImgCodecInstanceCreateInfo()
            {
                StructType = NvImgCodecStructureType.InstanceCreateInfo,
                StructSize = (UIntPtr)Marshal.SizeOf(typeof(NvImgCodecInstanceCreateInfo)),
                StructNext = IntPtr.Zero,
                LoadBuiltinModules = 1,
                LoadExtensionModules = 1,
                CreateDebugMessenger = 1
            };
            var createResult = Functions.NvImgCodecInstanceCreate(ref instance, ref createInfo);
            if (createResult != 0)
            {
                Console.WriteLine("Failed to initialize nvImgCodec Library");
            }
            //var destroyResult = Functions.NvImgCodecInstanceDestroy(instance);
            return instance;
        }

        //public static NvImgCodecDecoder CreateDecoder(NvImgCodecInstance instance)
        //{
        //    NvImgCodecDecoder decoder = new NvImgCodecDecoder();
        //    NvImgCodecExecutionParams executionParams = new NvImgCodecExecutionParams();
        //    var createResult = Functions.NvImgCodecDecoderCreate(instance,ref decoder,)
        //}


        public static NvImgCodecCodeStream ReadImageFromFile(NvImgCodecInstance instance, string imagePath)
        {
            NvImgCodecCodeStream codeStream = new NvImgCodecCodeStream();
            var readResult = Functions.NvImgCodecCodeStreamCreateFromFile(instance, ref codeStream, imagePath);
            if (readResult != 0)
            {
                Console.WriteLine("Failed to create codeStream form File");
            }
            return codeStream;
        }

        public static NvImgCodecImageInfo GetImageInfoFromCodeStream(ref NvImgCodecCodeStream codeStream)
        {
            NvImgCodecImageInfo imageInfo = new NvImgCodecImageInfo();

            var getInfoResult = Functions.NvImgCodecCodeStreamGetImageInfo(codeStream, ref imageInfo);
            if (getInfoResult != 0)
            {
                Console.WriteLine("Failed to get image info from code stream");
            }

            Console.WriteLine($"Input image info:");
            Console.WriteLine($"\t - Width:{imageInfo.PlaneInfo[0].Width}");
            Console.WriteLine($"\t - Height:{imageInfo.PlaneInfo[0].Height}");
            Console.WriteLine($"\t - Components:{imageInfo.NumPlanes}");
            //Console.WriteLine($"\t - Codec:{imageInfo.CodecName}");
            return imageInfo;
        }

        public static void TestReadImageFromFile(string imagePath)
        {
            NvImgCodecInstance instance = Initialize();
            NvImgCodecCodeStream codeStream = ReadImageFromFile(instance, imagePath);
            NvImgCodecImageInfo imageInfo = GetImageInfoFromCodeStream(ref codeStream);

        }
        public static void CreateImageInfo(uint width, uint height)
        {
            NvImgCodecImageInfo inputImageInfo = new NvImgCodecImageInfo()
            {
                StructType = NvImgCodecStructureType.ImageInfo,
                StructSize = (UIntPtr)Marshal.SizeOf(typeof(NvImgCodecImageInfo)),
                StructNext = IntPtr.Zero,
                NumPlanes = 3,  //sample format is planar RGB so 3 planes each with 1 channel
                ColorSpec = NvImgCodecColorSpec.Srgb,
                SampleFormat = NvImgCodecSampleFormat.PlanarRgb,
                ChromaSubsampling = NvImgCodecChromaSubsampling.Sampling420
            };

            inputImageInfo.PlaneInfo[0].Height = height;
            inputImageInfo.PlaneInfo[0].Width = width;
            inputImageInfo.PlaneInfo[0].NumChannels = 1;

            NvImgCodecSampleDataType sampleDataType = NvImgCodecSampleDataType.UInt8;

            // For general case, having sample type,  we can calculate bytes per element using formula static_cast< unsigned int> (sample_type) >> (8 + 3);
            // so shift by 8 since 8..15 bits represents type bitdepth,  then shift by 3 to convert to # bytes
            // here we can simple assign 1 as we assumed type is uint8
            uint bytesPerElement = 1;
            uint pitchInBytes = inputImageInfo.PlaneInfo[0].Width * inputImageInfo.PlaneInfo[0].NumChannels * bytesPerElement;

            uint bufferSize = 0;
            for (uint p = 0; p< inputImageInfo.NumPlanes; p++)
            {
                inputImageInfo.PlaneInfo[p].Width = inputImageInfo.PlaneInfo[0].Width;
                inputImageInfo.PlaneInfo[p].Height = inputImageInfo.PlaneInfo[0].Height;
                inputImageInfo.PlaneInfo[p].RowStride = pitchInBytes;
                inputImageInfo.PlaneInfo[p].SampleType = sampleDataType;
                inputImageInfo.PlaneInfo[p].NumChannels = inputImageInfo.PlaneInfo[0].NumChannels;
                inputImageInfo.PlaneInfo[p].Precision = 8;
                bufferSize += inputImageInfo.PlaneInfo[p].RowStride * inputImageInfo.PlaneInfo[p].Height;
            }
            inputImageInfo.BufferKind = NvImgCodecImageBufferKind.StridedHost;

        }
    }
}