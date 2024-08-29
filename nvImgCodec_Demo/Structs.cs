using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NvImgCodec
{
    /// <summary>
    /// Maximal size of codec name
    /// </summary>
    public static class Constants
    {
        public const int NVIMGCODEC_MAX_CODEC_NAME_SIZE = 256;
        public const int NVIMGCODEC_DEVICE_CURRENT = -1;
        public const int NVIMGCODEC_DEVICE_CPU_ONLY = -99999;
        public const int NVIMGCODEC_MAX_NUM_DIM = 5;
        public const int NVIMGCODEC_MAX_NUM_PLANES = 32;
        public const int NVIMGCODEC_JPEG2K_MAXRES = 33;
    }

    /// <summary>
    /// Opaque nvImageCodec library instance type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecInstance
    {
        private IntPtr handle; // internal handle to the opaque instance
    }

    /// <summary>
    /// Handle to opaque nvImageCodec library instance type.
    /// </summary>
    public class NvImgCodecInstanceHandle : SafeHandle
    {
        public NvImgCodecInstanceHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecInstanceHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Image type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecImage
    {
        private IntPtr handle; // internal handle to the opaque image
    }

    /// <summary>
    /// Handle to opaque Image type.
    /// </summary>
    public class NvImgCodecImageHandle : SafeHandle
    {
        public NvImgCodecImageHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecImageHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Code Stream type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecCodeStream
    {
        public IntPtr Handle { get; set; } // internal handle to the opaque code stream
    }

    /// <summary>
    /// Handle to opaque Code Stream type.
    /// </summary>
    public class NvImgCodecCodeStreamHandle : SafeHandle
    {
        public NvImgCodecCodeStreamHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecCodeStreamHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Parser type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecParser
    {
        private IntPtr handle; // internal handle to the opaque parser
    }

    /// <summary>
    /// Handle to opaque Parser type.
    /// </summary>
    public class NvImgCodecParserHandle : SafeHandle
    {
        public NvImgCodecParserHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecParserHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Encoder type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecEncoder
    {
        private IntPtr handle; // internal handle to the opaque encoder
    }

    /// <summary>
    /// Handle to opaque Encoder type.
    /// </summary>
    public class NvImgCodecEncoderHandle : SafeHandle
    {
        public NvImgCodecEncoderHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecEncoderHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Decoder type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecDecoder
    {
        private IntPtr handle; // internal handle to the opaque decoder
    }

    /// <summary>
    /// Handle to opaque Decoder type.
    /// </summary>
    public class NvImgCodecDecoderHandle : SafeHandle
    {
        public NvImgCodecDecoderHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecDecoderHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Debug Messenger type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecDebugMessenger
    {
        private IntPtr handle; // internal handle to the opaque debug messenger
    }

    /// <summary>
    /// Handle to opaque Debug Messenger type.
    /// </summary>
    public class NvImgCodecDebugMessengerHandle : SafeHandle
    {
        public NvImgCodecDebugMessengerHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecDebugMessengerHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Extension type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecExtension
    {
        private IntPtr handle; // internal handle to the opaque extension
    }

    /// <summary>
    /// Handle to opaque Extension type.
    /// </summary>
    public class NvImgCodecExtensionHandle : SafeHandle
    {
        public NvImgCodecExtensionHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecExtensionHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Opaque Future type.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecFuture
    {
        private IntPtr handle; // internal handle to the opaque future
    }

    /// <summary>
    /// Handle to opaque Future type.
    /// </summary>
    public class NvImgCodecFutureHandle : SafeHandle
    {
        public NvImgCodecFutureHandle() : base(IntPtr.Zero, true) { }

        public NvImgCodecFutureHandle(IntPtr handle) : base(handle, true) { }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            // Implement the release logic if necessary
            return true;
        }
    }

    /// <summary>
    /// Structure types supported by the nvImageCodec API.
    /// Each value corresponds to a particular structure with a type member and matching structure name.
    /// </summary>
    public enum NvImgCodecStructureType
    {
        Properties,
        InstanceCreateInfo,
        DeviceAllocator,
        PinnedAllocator,
        DecodeParams,
        EncodeParams,
        Orientation,
        Region,
        ImageInfo,
        ImagePlaneInfo,
        JpegImageInfo,
        JpegEncodeParams,
        Jpeg2kImageInfo,
        Jpeg2kEncodeParams,
        Backend,
        IoStreamDesc,
        FrameworkDesc,
        DecoderDesc,
        EncoderDesc,
        ParserDesc,
        ImageDesc,
        CodeStreamDesc,
        DebugMessengerDesc,
        DebugMessageData,
        ExtensionDesc,
        ExecutorDesc,
        BackendParams,
        ExecutionParams,
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// The nvImageCodec properties.
    /// </summary>
    /// <remarks>
    /// See <see cref="nvimgcodecGetProperties"/>.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecProperties
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                    // Is NULL or a pointer to an extension structure type.

        public uint Version;          // The nvImageCodec library version.
        public uint ExtApiVersion;    // The nvImageCodec extension API version.
        public uint CudaRtVersion;    // The version of CUDA Runtime with which nvImageCodec library was built.
    }

    /// <summary>
    /// Function type for device memory resource allocation.
    /// </summary>
    /// <param name="ctx">Pointer to user context.</param>
    /// <param name="ptr">Pointer where to write pointer to allocated memory.</param>
    /// <param name="size">How many bytes to allocate.</param>
    /// <param name="stream">CUDA stream.</param>
    /// <returns>Returns 0 in case of success, and non-zero otherwise.</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int NvImgCodecDeviceMalloc(IntPtr ctx, out IntPtr ptr, UIntPtr size, IntPtr stream);

    /// <summary>
    /// Function type for device memory deallocation.
    /// </summary>
    /// <param name="ctx">Pointer to user context.</param>
    /// <param name="ptr">Pointer to memory buffer to be deallocated. If NULL, the operation must do nothing, successfully.</param>
    /// <param name="size">How many bytes were allocated (size passed during allocation).</param>
    /// <param name="stream">CUDA stream.</param>
    /// <returns>Returns 0 in case of success, and non-zero otherwise.</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int NvImgCodecDeviceFree(IntPtr ctx, IntPtr ptr, UIntPtr size, IntPtr stream);

    /// <summary>
    /// Function type for host pinned memory resource allocation.
    /// </summary>
    /// <param name="ctx">Pointer to user context.</param>
    /// <param name="ptr">Pointer where to write pointer to allocated memory.</param>
    /// <param name="size">How many bytes to allocate.</param>
    /// <param name="stream">CUDA stream.</param>
    /// <returns>Returns 0 in case of success, and non-zero otherwise.</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int NvImgCodecPinnedMalloc(IntPtr ctx, out IntPtr ptr, UIntPtr size, IntPtr stream);

    /// <summary>
    /// Function type for host pinned memory deallocation.
    /// </summary>
    /// <param name="ctx">Pointer to user context.</param>
    /// <param name="ptr">Pointer to memory buffer to be deallocated. If NULL, the operation must do nothing, successfully.</param>
    /// <param name="size">How many bytes were allocated (size passed during allocation).</param>
    /// <param name="stream">CUDA stream.</param>
    /// <returns>Returns 0 in case of success, and non-zero otherwise.</returns>
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int NvImgCodecPinnedFree(IntPtr ctx, IntPtr ptr, UIntPtr size, IntPtr stream);

    /// <summary>
    /// Device memory allocator.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecDeviceAllocator
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                    // Is NULL or a pointer to an extension structure type.

        public NvImgCodecDeviceMalloc DeviceMalloc;  // Allocate memory on the device.
        public NvImgCodecDeviceFree DeviceFree;      // Frees memory on the device.
        public IntPtr DeviceCtx;                     // When invoking the allocators, this context will be passed as input to allocator functions.
        public UIntPtr DeviceMemPadding;             // Any device memory allocation would be padded to the multiple of specified number of bytes.
    }

    /// <summary>
    /// Host pinned memory allocator.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecPinnedAllocator
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                    // Is NULL or a pointer to an extension structure type.

        public NvImgCodecPinnedMalloc PinnedMalloc;  // Allocate host pinned memory: memory directly accessible by both CPU and cuda-enabled GPU.
        public NvImgCodecPinnedFree PinnedFree;      // Frees host pinned memory.
        public IntPtr PinnedCtx;                     // When invoking the allocators, this context will be passed as input to allocator functions.
        public UIntPtr PinnedMemPadding;             // Any pinned host memory allocation would be padded to the multiple of specified number of bytes.
    }

    /// <summary>
    /// The return status codes of the nvImageCodec API.
    /// </summary>
    public enum NvImgCodecStatus
    {
        Success = 0,
        NotInitialized = 1,
        InvalidParameter = 2,
        BadCodeStream = 3,
        CodeStreamUnsupported = 4,
        AllocatorFailure = 5,
        ExecutionFailed = 6,
        ArchMismatch = 7,
        InternalError = 8,
        ImplementationUnsupported = 9,
        MissedDependencies = 10,
        ExtensionNotInitialized = 11,
        ExtensionInvalidParameter = 12,
        ExtensionBadCodeStream = 13,
        ExtensionCodeStreamUnsupported = 14,
        ExtensionAllocatorFailure = 15,
        ExtensionArchMismatch = 16,
        ExtensionInternalError = 17,
        ExtensionImplementationNotSupported = 18,
        ExtensionIncompleteBitstream = 19,
        ExtensionExecutionFailed = 20,
        ExtensionCudaCallError = 21,
        EnumForceInt = int.MaxValue
    }
    /// <summary>
    /// Describes the type sample of data.
    /// Meaning of bits:
    /// 0 bit      -> 0 - unsigned, 1 - signed
    /// 1..7 bits  -> define type
    /// 8..15 bits -> type bit depth
    /// </summary>
    public enum NvImgCodecSampleDataType
    {
        Unknown = 0,
        Int8 = 0x0801,
        UInt8 = 0x0802,
        Int16 = 0x1003,
        UInt16 = 0x1004,
        Int32 = 0x2005,
        UInt32 = 0x2006,
        Int64 = 0x4007,
        UInt64 = 0x4008,
        Float16 = 0x1009,
        Float32 = 0x200B,
        Float64 = 0x400D,
        Unsupported = -1,
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// Chroma subsampling.
    /// </summary>
    public enum NvImgCodecChromaSubsampling
    {
        None = 0,
        Sampling444 = None,
        Sampling422 = 2,
        Sampling420 = 3,
        Sampling440 = 4,
        Sampling411 = 5,
        Sampling410 = 6,
        Gray = 7,
        Sampling410V = 8,
        Unsupported = -1,
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// Provides information on how color components are matched to channels in a given order and how channels are matched to planes.
    /// </summary>
    public enum NvImgCodecSampleFormat
    {
        Unknown = 0,
        PlanarUnchanged = 1,      // unchanged planar
        InterleavedUnchanged = 2, // unchanged interleaved
        PlanarRgb = 3,            // planar RGB
        InterleavedRgb = 4,       // interleaved RGB
        PlanarBgr = 5,            // planar BGR
        InterleavedBgr = 6,       // interleaved BGR
        PlanarY = 7,              // Y component only
        PlanarYuv = 9,            // YUV planar format
        Unsupported = -1,
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// Defines color specification.
    /// </summary>
    public enum NvImgCodecColorSpec
    {
        Unknown = 0,
        Unchanged = Unknown,
        Srgb = 1,
        Gray = 2,
        Sycc = 3,
        Cmyk = 4,
        Ycck = 5,
        Unsupported = -1,
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// Defines orientation of an image.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecOrientation
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                 // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        public int Rotated; // Rotation angle in degrees (clockwise). Only multiples of 90 are allowed.
        public int FlipX;   // Flip horizontal (0 or 1).
        public int FlipY;   // Flip vertical (0 or 1).

        public NvImgCodecOrientation()
        {
            StructType = NvImgCodecStructureType.Orientation;
            StructSize = (UIntPtr)Marshal.SizeOf(typeof(NvImgCodecOrientation));
            StructNext = IntPtr.Zero;
            Rotated = 0;
            FlipX = 0;
            FlipY = 0;
        }
    }

    /// <summary>
    /// Defines the plane of an image.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecImagePlaneInfo
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                 // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        public uint Width;                        // Plane width. First plane defines the width of the image.
        public uint Height;                       // Plane height. First plane defines the height of the image.
        public uint RowStride;                 // Number of bytes needed to offset to the next row of the plane.
        public uint NumChannels;                  // Number of channels. Color components are always first, but there can be more channels than color components.
        public NvImgCodecSampleDataType SampleType; // Sample data type.
        public byte Precision;                    // Value 0 means that precision is equal to the sample type bit depth.

        public NvImgCodecImagePlaneInfo()
        {
            StructType = NvImgCodecStructureType.ImagePlaneInfo;
            StructSize = (UIntPtr)Marshal.SizeOf(typeof(NvImgCodecImagePlaneInfo));
            StructNext = IntPtr.Zero;
            Width = 0;
            Height = 0;
            RowStride = 0;
            NumChannels = 0;
            SampleType = NvImgCodecSampleDataType.Unknown;
            Precision = 0;
        }
    }

    /// <summary>
    /// Defines a region of an image.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecRegion
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                 // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        public int NDim;                           // Number of dimensions, 0 value means no region.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.NVIMGCODEC_MAX_NUM_DIM)]
        public int[] Start;                        // Region start position at the particular dimension.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.NVIMGCODEC_MAX_NUM_DIM)]
        public int[] End;                          // Region end position at the particular dimension.

        public NvImgCodecRegion()
        {
            StructType = NvImgCodecStructureType.Region;
            StructSize = (UIntPtr)Marshal.SizeOf(typeof(NvImgCodecRegion));
            StructNext = IntPtr.Zero;
            NDim = 0;
            Start = new int[Constants.NVIMGCODEC_MAX_NUM_DIM];
            End = new int[Constants.NVIMGCODEC_MAX_NUM_DIM];
        }
    }

    /// <summary>
    /// Defines buffer kind in which image data is stored.
    /// </summary>

    public enum NvImgCodecImageBufferKind
    {
        Unknown = 0,
        StridedDevice = 1, // GPU-accessible with planes in pitch-linear layout. 
        StridedHost = 2,   // Host-accessible with planes in pitch-linear layout. 
        Unsupported = -1,
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// Defines information about an image.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NvImgCodecImageInfo
    {
        public NvImgCodecStructureType StructType; // The type of the structure. 
        public UIntPtr StructSize;                    // The size of the structure, in bytes. 
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type. 


        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.NVIMGCODEC_MAX_CODEC_NAME_SIZE)]
        public string CodecName;                   // Information about codec used. Only valid when used with code stream. 

        //public StringBuilder CodecName;

        public NvImgCodecColorSpec ColorSpec;     // Image color specification. 
        public NvImgCodecChromaSubsampling ChromaSubsampling; // Image chroma subsampling. Only valid with chroma components. 
        public NvImgCodecSampleFormat SampleFormat; // Defines how color components are matched to channels in given order and channels are matched to planes.
        public NvImgCodecOrientation Orientation;   // Image orientation. 
        public NvImgCodecRegion Region;             // Region of interest. 

        public uint NumPlanes;                    // Number of image planes. 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.NVIMGCODEC_MAX_NUM_PLANES)]
        public NvImgCodecImagePlaneInfo[] PlaneInfo; // Array with information about image planes. 

        public IntPtr Buffer;                    // Pointer to buffer in which image data is stored. 
        public ulong BufferSize;               // Size of buffer in which image data is stored. 
        public NvImgCodecImageBufferKind BufferKind; // Buffer kind in which image data is stored.

        public IntPtr CudaStream;                // CUDA stream to synchronize with 

        public NvImgCodecImageInfo()
        {
            StructType = NvImgCodecStructureType.ImageInfo;
            StructSize = (UIntPtr)Marshal.SizeOf(typeof(NvImgCodecImageInfo));
            StructNext = IntPtr.Zero;
            PlaneInfo = new NvImgCodecImagePlaneInfo[Constants.NVIMGCODEC_MAX_NUM_PLANES];
            for (int p=0; p < PlaneInfo.Length; p++)
            {
                PlaneInfo[p] = new NvImgCodecImagePlaneInfo();
            }
            CodecName = string.Empty;
            ColorSpec = NvImgCodecColorSpec.Unknown;
            ChromaSubsampling = NvImgCodecChromaSubsampling.None;
            SampleFormat = NvImgCodecSampleFormat.Unknown;
            Orientation = new NvImgCodecOrientation();
            Region = new NvImgCodecRegion();
            NumPlanes = 0;
            Buffer = IntPtr.Zero;
            BufferSize = 0;
            BufferKind = NvImgCodecImageBufferKind.Unknown;
            CudaStream = IntPtr.Zero;
        } 
    }

    /// <summary>
    /// JPEG Encoding
    /// Currently parseable JPEG encodings(SOF markers)
    /// https://www.w3.org/Graphics/JPEG/itu-t81.pdf
    /// Table B.1 Start of Frame markers
    /// </summary>
    public enum NvImgCodecJpegEncoding
    {
        Unknown = 0x0,
        BaselineDct = 0xc0,
        ExtendedSequentialDctHuffman = 0xc1,
        ProgressiveDctHuffman = 0xc2,
        LosslessHuffman = 0xc3,
        DifferentialSequentialDctHuffman = 0xc5,
        DifferentialProgressiveDctHuffman = 0xc6,
        DifferentialLosslessHuffman = 0xc7,
        ReservedForJpegExtensions = 0xc8,
        ExtendedSequentialDctArithmetic = 0xc9,
        ProgressiveDctArithmetic = 0xca,
        LosslessArithmetic = 0xcb,
        DifferentialSequentialDctArithmetic = 0xcd,
        DifferentialProgressiveDctArithmetic = 0xce,
        DifferentialLosslessArithmetic = 0xcf,
        EnumForceInt = int.MaxValue
    }


    ///<summary>
    /// Defines image information related to JPEG format.
    /// 
    /// This structure extends information provided in NvImgCodecImageInfo 
    /// </summary>>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecJpegImageInfo
    {
        public NvImgCodecStructureType StructType; /**< The type of the structure. */
        public IntPtr StructNext;                  /**< Is NULL or a pointer to an extension structure type. */
        public UIntPtr StructSize;                    /**< The size of the structure, in bytes. */

        public NvImgCodecJpegEncoding Encoding; /**< JPEG encoding type. */
    }

    /// <summary>
    /// Defines image information related to JPEG2000 format.
    /// This structure extends information provided in NvImgCodecImageInfo.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecJpeg2kImageInfo
    {
        public NvImgCodecStructureType StructType; /// The type of the structure.
        public IntPtr StructNext;                  /// Is NULL or a pointer to an extension structure type.
        public UIntPtr StructSize;                    /// The size of the structure, in bytes.

        public uint NumTilesY;                    /// Number of tile rows.
        public uint NumTilesX;                    /// Number of tile columns.
        public uint TileHeight;                   /// Height of the tile.
        public uint TileWidth;                    /// Width of the tile.
    }

    /// <summary>
    /// Defines decoding/encoding backend kind.
    /// </summary>
    public enum NvImgCodecBackendKind
    {
        CpuOnly = 1,       ///< Decoding/encoding is executed only on CPU.
        GpuOnly = 2,       ///< Decoding/encoding is executed only on GPU.
        HybridCpuGpu = 3, ///< Decoding/encoding is executed on both CPU and GPU.
        HwGpuOnly = 4,    ///< Decoding/encoding is executed on GPU dedicated hardware engine.
    }

    /// <summary>
    /// Defines decoding/encoding backend parameters.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecBackendParams
    {
        public NvImgCodecStructureType StructType; /// The type of the structure.
        public UIntPtr StructSize;                    /// The size of the structure, in bytes.
        public IntPtr StructNext;                  /// Is NULL or a pointer to an extension structure type.

                                                   /// <summary>
                                                   /// Fraction of the batch items that will be picked by this backend.
                                                   /// The remaining items will be marked as "saturated" status and will be picked by the next backend.
                                                   /// This is just a hint and a particular implementation can choose to ignore it.
                                                   /// </summary>
        public float LoadHint;
    }

    /// <summary>
    /// Defines decoding/encoding backend.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecBackend
    {
        public NvImgCodecStructureType StructType; /// The type of the structure.
        public UIntPtr StructSize;                    /// The size of the structure, in bytes.
        public IntPtr StructNext;                  /// Is NULL or a pointer to an extension structure type.

        public NvImgCodecBackendKind Kind;     /// Decoding/encoding backend kind.
        public NvImgCodecBackendParams Params; /// Decoding/encoding backend parameters.
    }

    /// <summary>
    /// Processing status bitmask for decoding or encoding.
    /// </summary>
    [Flags]
    public enum NvImgCodecProcessingStatus
    {
        Unknown = 0x0,
        Success = 0x1,   ///< Processing finished with success.
        Saturated = 0x2, ///< Decoder/encoder could potentially process image but is saturated. @see NvImgCodecBackendParams LoadHint.
        Fail = 0x3,                    /// Processing failed because unknown reason.
        ImageCorrupted = 0x7,         /// Processing failed because compressed image stream is corrupted.
        CodecUnsupported = 0xb,       /// Processing failed because codec is unsupported.
        BackendUnsupported = 0x13,    /// Processing failed because no one from allowed backends is supported.
        EncodingUnsupported = 0x23,   /// Processing failed because codec encoding is unsupported.
        ResolutionUnsupported = 0x43, /// Processing failed because image resolution is unsupported.
        CodestreamUnsupported = 0x83, /// Processing failed because some feature of compressed stream is unsupported.

        // These values below describe cases when processing could be possible but with different image format or parameters
        ColorSpecUnsupported = 0x5,     /// Color specification unsupported.
        OrientationUnsupported = 0x9,    /// Apply orientation was enabled but it is unsupported.
        RoiUnsupported = 0x11,           /// Decoding region of interest is unsupported.
        SamplingUnsupported = 0x21,      /// Selected unsupported chroma subsampling.
        SampleTypeUnsupported = 0x41,   /// Selected unsupported sample type.
        SampleFormatUnsupported = 0x81, /// Selected unsupported sample format.
        NumPlanesUnsupported = 0x101,   /// Unsupported number of planes to decode/encode.
        NumChannelsUnsupported = 0x201, /// Unsupported number of channels to decode/encode.

        EnumForceInt = int.MaxValue
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecDecodeParams
    {
        public NvImgCodecStructureType StructType; /// The type of the structure.
        public UIntPtr StructSize;                    /// The size of the structure, in bytes.
        public IntPtr StructNext;                  /// Is NULL or a pointer to an extension structure type.

                                                   ///<summary>
                                                   /// Apply EXIF orientation if available. Valid values 0 or 1.
                                                   ///</summary>
        public int ApplyExifOrientation;

        ///<summary>
        /// Enables region of interest. Valid values 0 or 1.
        ///</summary>
        public int EnableRoi;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecEncodeParams
    {
        public NvImgCodecStructureType StructType; /// The type of the structure.
        public UIntPtr StructSize;                    /// The size of the structure, in bytes.
        public IntPtr StructNext;                  /// Is NULL or a pointer to an extension structure type.

                                                   ///<summary>
                                                   /// Float value of quality which interpretation depends on particular codec.
                                                   /// For JPEG codec it is expected to be integer values between 1 and 100, where 100 is the highest quality. Default value is 70.
                                                   /// @warning For JPEG2000 it is unsupported and target_psnr should be used instead.
                                                   ///</summary>
        public float Quality;

        ///<summary>
        /// Float value of target PSNR (Peak Signal to Noise Ratio)
        /// @warning It is valid only for lossy encoding.
        /// @warning It is not supported by all codecs.
        ///</summary>
        public float TargetPsnr;
    }

    // Defines progression orders in the JPEG2000 standard.
    public enum NvImgCodecJpeg2kProgOrder
    {
        Lrcp = 0, // Layer-Resolution-Component-Position progression order.
        Rlcp = 1, // Resolution-Layer-Component-Position progression order.
        Rpcl = 2, // Resolution-Position-Component-Layer progression order.
        Pcrl = 3, // Position-Component-Resolution-Layer progression order.
        Cprl = 4, // Component-Position-Resolution-Layer progression order.
        EnumForceInt = int.MaxValue
    }

    // Defines JPEG2000 code stream types.
    public enum NvImgCodecJpeg2kBitstreamType
    {
        J2k = 0, // Corresponds to the JPEG2000 code stream.
        Jp2 = 1, // Corresponds to the .jp2 container.
        EnumForceInt = int.MaxValue
    }

    // Defines parameters for JPEG2000 encoding.
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecJpeg2kEncodeParams
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                    // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        public NvImgCodecJpeg2kBitstreamType StreamType; // JPEG2000 code stream type.
        public NvImgCodecJpeg2kProgOrder ProgOrder;      // JPEG2000 progression order.
        public uint NumResolutions;                    // Number of resolutions.
        public uint CodeBlockW;                       // Code block width. Allowed values 32, 64.
        public uint CodeBlockH;                       // Code block height. Allowed values 32, 64.
        public int Irreversible;                      // Sets whether or not to use irreversible encoding. Valid values 0 or 1.
    }

    // Defines parameters for JPEG encoding.
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecJpegEncodeParams
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                    // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        // Sets whether or not to use optimized Huffman. Valid values 0 or 1.
        // Using optimized Huffman produces smaller JPEG bitstream sizes with the same quality, but with slower performance.
        public int OptimizedHuffman;
    }

    /// <summary>
    /// Bitmask specifying which severities of events cause a debug messenger callback.
    /// </summary>
    [Flags]
    public enum NvImgCodecDebugMessageSeverity
    {
        None = 0x00000000,               // No severity level.
        Trace = 0x00000001,              // Diagnostic message useful for developers.
        Debug = 0x00000010,              // Diagnostic message useful for developers.
        Info = 0x00000100,               // Informational message like the creation of a resource.
        Warning = 0x00001000,            // Message about behavior that is not necessarily an error, but very likely a bug in your application.
        Error = 0x00010000,              // Message about behavior that is invalid and may cause improper execution or result of operation (e.g., can't open file) but not application.
        Fatal = 0x00100000,              // Message about behavior that is invalid and may cause crashes and forcing to shutdown application.
        All = 0x0FFFFFFF,                // Used in case filtering out by message severity.
        Default = Warning | Error | Fatal, // Default severity levels.
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// Bitmask specifying which category of events cause a debug messenger callback.
    /// </summary>
    [Flags]
    public enum NvImgCodecDebugMessageCategory
    {
        None = 0x00000000,                 // No category.
        General = 0x00000001,              // Some event has happened that is unrelated to the specification or performance.
        Validation = 0x00000010,           // Something has happened that indicates a possible mistake.
        Performance = 0x00000100,          // Potential non-optimal use.
        All = 0x0FFFFFFF,                  // Used in case filtering out by message category.
        EnumForceInt = int.MaxValue
    }

    /// <summary>
    /// Describing debug message passed to debug callback function.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecDebugMessageData
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                 // Is NULL or a pointer to an extension structure type.

        public string Message;                    // Null-terminated string detailing the trigger conditions.
        public uint InternalStatusId;             // Internal codec status id.
        public string Codec;                      // Codec name if codec is raising message or NULL otherwise (e.g., framework).
        public string CodecId;                    // Codec id if codec is raising message or NULL otherwise.
        public uint CodecVersion;                 // Codec version if codec is raising message or 0 otherwise.
    }

    /// <summary>
    /// Debug callback function type.
    /// </summary>
    /// <param name="messageSeverity">Message severity</param>
    /// <param name="messageCategory">Message category</param>
    /// <param name="callbackData">Debug message data</param>
    /// <param name="userData">Pointer that was specified during the setup of the callback</param>
    /// <returns>1 if message should not be passed further to other callbacks and 0 otherwise</returns>
    public delegate int NvImgCodecDebugCallback(
        NvImgCodecDebugMessageSeverity messageSeverity,
        NvImgCodecDebugMessageCategory messageCategory,
        ref NvImgCodecDebugMessageData callbackData,
        IntPtr userData
    );

    /// <summary>
    /// Debug messenger description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecDebugMessengerDesc
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                     // The size of the structure, in bytes.
        public IntPtr StructNext;                   // Is NULL or a pointer to an extension structure type.

        public uint MessageSeverity;                // Bitmask of message severity to listen for e.g., error or warning.
        public uint MessageCategory;                // Bitmask of message category to listen for e.g., general or performance related.
        public NvImgCodecDebugCallback UserCallback; // Debug callback function.
        public IntPtr UserData;                     // Pointer to user data which will be passed back to debug callback function.
    }

    /// <summary>
    /// Executor description.
    /// Codec plugins can use executor available via execution parameters to schedule execution of asynchronous task.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecExecutorDesc
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                 // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                   // Executor instance pointer which will be passed back in functions.

        /// <summary>
        /// Schedule execution of asynchronous task.
        /// </summary>
        /// <param name="instance">Pointer to nvimgcodecExecutorDesc_t instance.</param>
        /// <param name="deviceId">Device id on which task will be executed.</param>
        /// <param name="sampleIdx">Index of batch sample to process task on; It will be passed back as an argument in task function.</param>
        /// <param name="taskContext">Pointer to task context which will be passed back as an argument in task function.</param>
        /// <param name="task">Pointer to task function to schedule.</param>
        /// <returns>nvimgcodecStatus_t - An error code as specified in {@link nvimgcodecStatus_t API Return Status Codes}</returns>
        public delegate NvImgCodecStatus NvImgCodecLaunchDelegate(
            IntPtr instance,
            int deviceId,
            int sampleIdx,
            IntPtr taskContext,
            Action<int, int, IntPtr> task
        );

        public NvImgCodecLaunchDelegate Launch; // Function to schedule execution of asynchronous task.

        /// <summary>
        /// Gets number of threads.
        /// </summary>
        /// <param name="instance">Pointer to nvimgcodecExecutorDesc_t instance.</param>
        /// <returns>Number of threads in executor.</returns>
        public delegate int NvImgCodecGetNumThreadsDelegate(IntPtr instance);

        public NvImgCodecGetNumThreadsDelegate GetNumThreads; // Function to get number of threads.
    }
    /// <summary>
    /// Execution parameters
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecExecutionParams
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        public NvImgCodecDeviceAllocator DeviceAllocator; // Custom allocator for device memory
        public NvImgCodecPinnedAllocator PinnedAllocator; // Custom allocator for pinned memory
        public int MaxNumCpuThreads;                      // Max number of CPU threads in default executor (0 means default value equal to number of cpu cores)
        public NvImgCodecExecutorDesc Executor;           // Points an executor. If NULL, default executor will be used.
                                                          // At plugin level API, it always points to executor, either custom or default.
        public int DeviceId;                              // Device id to process decoding on. It can also be specified using defines NVIMGCODEC_DEVICE_CURRENT or NVIMGCODEC_DEVICE_CPU_ONLY.
        public int PreInit;                               // If true, all relevant resources are initialized at the creation of the instance.
        public int NumBackends;                           // Number of allowed backends passed (if any) in backends parameter. For 0, all backends are allowed.
        public NvImgCodecBackend Backends;                           // Points to a NvImgCodecBackend array with defined allowed backends. For nullptr, all backends are allowed.
    }

    /// <summary>
    /// Input/Output stream description.
    /// This abstracts source or sink for code stream bytes.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecIoStreamDesc
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                     // The size of the structure, in bytes.
        public IntPtr StructNext;                    // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                     // I/O stream description instance pointer which will be passed back in functions.

        // Delegates for function pointers

        /// <summary>
        /// Reads all requested data from the stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="outputSize">Pointer to where to return number of read bytes.</param>
        /// <param name="buf">Pointer to output buffer.</param>
        /// <param name="bytes">Number of bytes to read.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus ReadDelegate(IntPtr instance, out ulong outputSize, IntPtr buf, ulong bytes);
        public ReadDelegate Read;

        /// <summary>
        /// Writes all requested data to the stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="outputSize">Pointer to where to return number of written bytes.</param>
        /// <param name="buf">Pointer to input buffer.</param>
        /// <param name="bytes">Number of bytes to write.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus WriteDelegate(IntPtr instance, out ulong outputSize, IntPtr buf, ulong bytes);
        public WriteDelegate Write;

        /// <summary>
        /// Writes one character to the stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="outputSize">Pointer to where to return number of written bytes.</param>
        /// <param name="ch">Character to write.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus PutcDelegate(IntPtr instance, out ulong outputSize, byte ch);
        public PutcDelegate Putc;

        /// <summary>
        /// Skips `count` objects in the stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="count">Number of bytes to skip.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus SkipDelegate(IntPtr instance, ulong count);
        public SkipDelegate Skip;

        /// <summary>
        /// Moves the read pointer in the stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="offset">Offset to move.</param>
        /// <param name="whence">Beginning - SEEK_SET, SEEK_CUR or SEEK_END.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus SeekDelegate(IntPtr instance, long offset, int whence);
        public SeekDelegate Seek;

        /// <summary>
        /// Retrieves current position, in bytes from the beginning, in the stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="offset">Pointer where to return current position.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus TellDelegate(IntPtr instance, out long offset);
        public TellDelegate Tell;

        /// <summary>
        /// Retrieves the length, in bytes, of the stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="size">Pointer where to return length of the stream.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus SizeDelegate(IntPtr instance, out ulong size);
        public SizeDelegate Size;

        /// <summary>
        /// Provides expected bytes which are going to be written.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="bytes">Number of expected bytes which are going to be written.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus ReserveDelegate(IntPtr instance, ulong bytes);
        public ReserveDelegate Reserve;

        /// <summary>
        /// Requests all data to be written to the output.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus FlushDelegate(IntPtr instance);
        public FlushDelegate Flush;

        /// <summary>
        /// Maps data into host memory.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="buffer">Points where to return pointer to mapped data. If data cannot be mapped, NULL will be returned.</param>
        /// <param name="offset">Offset in the stream to begin mapping.</param>
        /// <param name="size">Length of the mapping.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus MapDelegate(IntPtr instance, out IntPtr buffer, ulong offset, ulong size);
        public MapDelegate Map;

        /// <summary>
        /// Unmaps previously mapped data.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecIoStreamDesc instance.</param>
        /// <param name="buffer">Pointer to mapped data.</param>
        /// <param name="size">Length of data to unmap.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus UnmapDelegate(IntPtr instance, IntPtr buffer, ulong size);
        public UnmapDelegate Unmap;
    }

    /// <summary>
    /// Code stream description.
    /// </summary>
    public struct NvImgCodecCodeStreamDesc
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                    // Code stream description instance pointer which will be passed back in functions
        public ulong Id;                           // Generated id that uniquely identifies the instance

        public NvImgCodecIoStreamDesc IoStream;    // I/O stream which works as a source or sink of code stream bytes

        /// <summary>
        /// Retrieves image information.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus GetImageInfoDelegate(IntPtr instance, out NvImgCodecImageInfo imageInfo);
        public GetImageInfoDelegate GetImageInfo;
    }

    /// <summary>
    /// Image description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecImageDesc
    {
        public NvImgCodecStructureType StructType; // The type of the structure.
        public UIntPtr StructSize;                   // The size of the structure, in bytes.
        public IntPtr StructNext;                  // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                    // Image instance pointer which will be passed back in functions

        /// <summary>
        /// Retrieves image info information.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus GetImageInfoDelegate(IntPtr instance, out NvImgCodecImageInfo imageInfo);
        public GetImageInfoDelegate GetImageInfo;

        /// <summary>
        /// Informs that host side of processing of image is ready.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus ImageReadyDelegate(IntPtr instance, out NvImgCodecProcessingStatus processingStatus);
        public ImageReadyDelegate ImageReady;
    }

    /// <summary>
    /// Parser description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecParserDesc
    {
        public NvImgCodecStructureType StructType;  // The type of the structure.
        public UIntPtr StructSize;                    // The size of the structure, in bytes.
        public IntPtr StructNext;                   // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                     // Parser description instance pointer which will be passed back in functions.
        public IntPtr Id;                           // Codec named identifier e.g. nvJpeg2000.
        public IntPtr Codec;                        // Codec name e.g. jpeg2000.

        // Delegate for function pointers

        /// <summary>
        /// Checks whether parser can parse given code stream.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecParserDesc instance.</param>
        /// <param name="result">Pointer to where to return result of parsing check. Valid values 0 or 1.</param>
        /// <param name="codeStream">Code stream to parse check.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus CanParseDelegate(IntPtr instance, out int result, IntPtr codeStream);
        public CanParseDelegate CanParse;

        /// <summary>
        /// Creates parser.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecParserDesc instance.</param>
        /// <param name="parser">Pointer to where to return handle to created parser.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus CreateDelegate(IntPtr instance, out IntPtr parser);
        public CreateDelegate Create;

        /// <summary>
        /// Destroys parser.
        /// </summary>
        /// <param name="parser">Parser handle to destroy.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus DestroyDelegate(IntPtr parser);
        public DestroyDelegate Destroy;

        /// <summary>
        /// Parses given code stream and returns image information.
        /// </summary>
        /// <param name="parser">Parser handle.</param>
        /// <param name="imageInfo">Pointer to where to return image information.</param>
        /// <param name="codeStream">Code stream to parse.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus GetImageInfoDelegate(IntPtr parser, out NvImgCodecImageInfo imageInfo, IntPtr codeStream);
        public GetImageInfoDelegate GetImageInfo;
    }

    // <summary>
    /// Encoder description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecEncoderDesc
    {
        public NvImgCodecStructureType StructType;  // The type of the structure.
        public UIntPtr StructSize;                    // The size of the structure, in bytes.
        public IntPtr StructNext;                   // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                     // Encoder description instance pointer which will be passed back in functions.
        public IntPtr Id;                           // Codec named identifier e.g. nvJpeg2000.
        public IntPtr Codec;                        // Codec name e.g. jpeg2000.
        public NvImgCodecBackendKind BackendKind;   // What kind of backend this encoder is using.

        // Delegate for function pointers

        /// <summary>
        /// Creates encoder.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecEncoderDesc instance.</param>
        /// <param name="encoder">Pointer to where to return handle to created encoder.</param>
        /// <param name="execParams">Pointer to execution parameters.</param>
        /// <param name="options">String with optional, space separated, list of parameters for encoders.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus CreateDelegate(
            IntPtr instance, out IntPtr encoder, IntPtr execParams, [MarshalAs(UnmanagedType.LPStr)] string options);
        public CreateDelegate Create;

        /// <summary>
        /// Destroys encoder.
        /// </summary>
        /// <param name="encoder">Encoder handle to destroy.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus DestroyDelegate(IntPtr encoder);
        public DestroyDelegate Destroy;

        /// <summary>
        /// Checks whether encoder can encode given batch of images to code stream and with provided parameters.
        /// </summary>
        /// <param name="encoder">Encoder handle to use for check.</param>
        /// <param name="status">Pointer to array of batch size and processing status where result will be returned.</param>
        /// <param name="images">Pointer to array of pointers of batch size with input images.</param>
        /// <param name="codeStreams">Pointer to array of pointers of batch size with output code streams.</param>
        /// <param name="batchSize">Number of items in batch to check.</param>
        /// <param name="params">Encode parameters which will be used with check.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus CanEncodeDelegate(
            IntPtr encoder, [In, Out] NvImgCodecProcessingStatus[] status, [In] IntPtr[] images, [In, Out] IntPtr[] codeStreams,
            int batchSize, IntPtr param);
        public CanEncodeDelegate CanEncode;

        /// <summary>
        /// Encode given batch of images to code streams with provided parameters.
        /// </summary>
        /// <param name="encoder">Encoder handle to use for encoding.</param>
        /// <param name="images">Pointer to array of pointers of batch size with input images.</param>
        /// <param name="codeStreams">Pointer to array of pointers of batch size with output code streams.</param>
        /// <param name="batchSize">Number of items in batch to encode.</param>
        /// <param name="params">Encode parameters.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus EncodeDelegate(
            IntPtr encoder, [In] IntPtr[] images, [In, Out] IntPtr[] codeStreams, int batchSize, IntPtr param);
        public EncodeDelegate Encode;
    }

    /// <summary>
    /// Decoder description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecDecoderDesc
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                     // The size of the structure, in bytes.
        public IntPtr StructNext;                    // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                     // Decoder description instance pointer which will be passed back in functions.
        public string Id;                           // Codec named identifier, e.g., nvJpeg2000.
        public string Codec;                        // Codec name, e.g., jpeg2000.
        public NvImgCodecBackendKind BackendKind;   // Backend kind.

        // Delegates for function pointers

        /// <summary>
        /// Creates decoder.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecDecoderDesc instance.</param>
        /// <param name="decoder">Points where to return handle to created decoder.</param>
        /// <param name="execParams">Points to execution parameters.</param>
        /// <param name="options">String with optional, space separated, list of parameters for decoders, in format "<encoder_id>:<parameter_name>=<parameter_value>".</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus CreateDecoderDelegate(IntPtr instance, out IntPtr decoder, IntPtr execParams, [MarshalAs(UnmanagedType.LPUTF8Str)] string options);
        public CreateDecoderDelegate Create;

        /// <summary>
        /// Destroys decoder.
        /// </summary>
        /// <param name="decoder">Decoder handle to destroy.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus DestroyDecoderDelegate(IntPtr decoder);
        public DestroyDecoderDelegate Destroy;

        /// <summary>
        /// Checks whether decoder can decode given batch of code streams to images with provided parameters.
        /// </summary>
        /// <param name="decoder">Decoder handle to use for check.</param>
        /// <param name="status">Points to array of batch size and NvImgCodecProcessingStatus type, where result will be returned.</param>
        /// <param name="codeStreams">Pointer to array of pointers of batch size with input code streams to check decoding.</param>
        /// <param name="images">Pointer to array of pointers of batch size with output images to check decoding.</param>
        /// <param name="batchSize">Number of items in batch to check.</param>
        /// <param name="param">Decode parameters which will be used with check.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus CanDecodeDelegate(IntPtr decoder, IntPtr status, IntPtr codeStreams, IntPtr images, int batchSize, IntPtr param);
        public CanDecodeDelegate CanDecode;

        /// <summary>
        /// Decode given batch of code streams to images with provided parameters.
        /// </summary>
        /// <param name="decoder">Decoder handle to use for decoding.</param>
        /// <param name="codeStreams">Pointer to array of pointers of batch size with input code streams.</param>
        /// <param name="images">Pointer to array of pointers of batch size with output images.</param>
        /// <param name="batchSize">Number of items in batch to encode.</param>
        /// <param name="param">Decode parameters.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus DecodeDelegate(IntPtr decoder, IntPtr codeStreams, IntPtr images, int batchSize, IntPtr param);
        public DecodeDelegate Decode;
    }


    /// <summary>
    /// Defines decoder or encoder priority in codec.
    /// 
    /// For each codec there can be more decoders and encoders registered. Every decoder and encoder is registered with defined priority.
    /// Decoding process starts with selecting the highest priority decoder and checks whether it can decode a particular code stream.
    /// In case decoding could not be handled by the selected decoder, there is a fallback mechanism which selects the next in priority decoder.
    /// There can be more decoders registered with the same priority. In such cases, decoders with the same priority are selected in order of registration.
    /// </summary>
    public enum NvImgCodecPriority
    {
        NVIMGCODEC_PRIORITY_HIGHEST = 0,
        NVIMGCODEC_PRIORITY_VERY_HIGH = 100,
        NVIMGCODEC_PRIORITY_HIGH = 200,
        NVIMGCODEC_PRIORITY_NORMAL = 300,
        NVIMGCODEC_PRIORITY_LOW = 400,
        NVIMGCODEC_PRIORITY_VERY_LOW = 500,
        NVIMGCODEC_PRIORITY_LOWEST = 1000,
        NVIMGCODEC_PRIORITY_ENUM_FORCE_INT = int.MaxValue
    }

    /// <summary>
    /// Pointer to logging function.
    /// </summary>
    /// <param name="instance">Plugin framework instance pointer</param>
    /// <param name="messageSeverity">Message severity e.g. error or warning.</param>
    /// <param name="messageCategory">Message category e.g. general or performance-related.</param>
    /// <param name="data">Debug message data i.e. message string, status, codec etc.</param>
    /// <returns>Returns nvimgcodecStatus_t - An error code as specified in the API Return Status Codes</returns>
    public delegate NvImgCodecStatus NvImgCodecLogFunc(IntPtr instance, NvImgCodecDebugMessageSeverity messageSeverity,
        NvImgCodecDebugMessageCategory messageCategory, ref NvImgCodecDebugMessageData data);

    /// <summary>
    /// Plugin Framework
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecFrameworkDesc
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                     // The size of the structure, in bytes.
        public IntPtr StructNext;                    // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                      // Plugin framework instance pointer which will be passed back in functions.
        public string Id;                            // Plugin framework named identifier, e.g., nvImageCodec.
        public uint Version;                         // Plugin framework version.
        public uint ExtApiVersion;                   // The nvImageCodec extension API version.
        public uint CudartVersion;                   // The version of CUDA Runtime with which the plugin framework was built.
        public NvImgCodecLogFunc Log;                // Pointer to logging function.

        // Delegates for function pointers

        /// <summary>
        /// Registers encoder plugin.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecFrameworkDesc instance.</param>
        /// <param name="desc">Pointer to encoder description.</param>
        /// <param name="priority">Priority of encoder.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus RegisterEncoderDelegate(IntPtr instance, ref NvImgCodecEncoderDesc desc, float priority);
        public RegisterEncoderDelegate RegisterEncoder;

        /// <summary>
        /// Unregisters encoder plugin.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecFrameworkDesc instance.</param>
        /// <param name="desc">Pointer to encoder description to unregister.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus UnregisterEncoderDelegate(IntPtr instance, ref NvImgCodecEncoderDesc desc);
        public UnregisterEncoderDelegate UnregisterEncoder;

        /// <summary>
        /// Registers decoder plugin.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecFrameworkDesc instance.</param>
        /// <param name="desc">Pointer to decoder description.</param>
        /// <param name="priority">Priority of decoder.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus RegisterDecoderDelegate(IntPtr instance, ref NvImgCodecDecoderDesc desc, float priority);
        public RegisterDecoderDelegate RegisterDecoder;

        /// <summary>
        /// Unregisters decoder plugin.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecFrameworkDesc instance.</param>
        /// <param name="desc">Pointer to decoder description to unregister.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus UnregisterDecoderDelegate(IntPtr instance, ref NvImgCodecDecoderDesc desc);
        public UnregisterDecoderDelegate UnregisterDecoder;

        /// <summary>
        /// Registers parser plugin.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecFrameworkDesc instance.</param>
        /// <param name="desc">Pointer to parser description.</param>
        /// <param name="priority">Priority of parser.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus RegisterParserDelegate(IntPtr instance, ref NvImgCodecParserDesc desc, float priority);
        public RegisterParserDelegate RegisterParser;

        /// <summary>
        /// Unregisters parser plugin.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecFrameworkDesc instance.</param>
        /// <param name="desc">Pointer to parser description to unregister.</param>
        /// <returns>An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus UnregisterParserDelegate(IntPtr instance, ref NvImgCodecParserDesc desc);
        public UnregisterParserDelegate UnregisterParser;
    }


    /// <summary>
    /// Extension description.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecExtensionDesc
    {
        public NvImgCodecStructureType StructType;   // The type of the structure.
        public UIntPtr StructSize;                     // The size of the structure, in bytes.
        public IntPtr StructNext;                    // Is NULL or a pointer to an extension structure type.

        public IntPtr Instance;                      // Extension instance pointer which will be passed back in functions.
        public string Id;                            // Extension named identifier, e.g., nvjpeg_ext.
        public uint Version;                         // Extension version. Used when registering the extension to check if there are newer versions.
        public uint ExtApiVersion;                   // The version of the nvImageCodec extension API with which the extension was built.

        /// <summary>
        /// Creates the extension.
        /// </summary>
        /// <param name="instance">Pointer to NvImgCodecExtensionDesc instance.</param>
        /// <param name="extension">Points to where the handle of the created extension is returned.</param>
        /// <param name="framework">Pointer to framework description which can be used to register plugins.</param>
        /// <returns>Returns nvimgcodecStatus_t - An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus CreateDelegate(IntPtr instance, out NvImgCodecExtension extension, ref NvImgCodecFrameworkDesc framework);

        /// <summary>
        /// Destroys the extension.
        /// </summary>
        /// <param name="extension">Handle of the extension to destroy.</param>
        /// <returns>Returns nvimgcodecStatus_t - An error code as specified in the API Return Status Codes.</returns>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate NvImgCodecStatus DestroyDelegate(NvImgCodecExtension extension);
    }


    /// <summary>
    /// Extension module entry function type.
    /// </summary>
    /// <param name="extDesc">Points to a nvimgcodecExtensionDesc handle in which the extension description is returned.</param>
    /// <returns>Returns nvimgcodecStatus_t - An error code as specified in the API Return Status Codes.</returns>
    public delegate NvImgCodecStatus NvImgCodecExtensionModuleEntryFunc(ref NvImgCodecExtensionDesc extDesc);

    /// <summary>
    /// The nvImageCodec library instance create information structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NvImgCodecInstanceCreateInfo
    {
        public NvImgCodecStructureType StructType;      // The type of the structure.
        public UIntPtr StructSize;                        // The size of the structure, in bytes.
        public IntPtr StructNext;                       // Is NULL or a pointer to an extension structure type.

        public int LoadBuiltinModules;                  // Load default modules. Valid values 0 or 1.
        public int LoadExtensionModules;                // Discover and load extension modules on start. Valid values 0 or 1.
        public string ExtensionModulesPath;             // There may be several paths separated by ':' on Linux or ';' on Windows.
        public int CreateDebugMessenger;                // Create debug messenger during instance creation. Valid values 0 or 1.

        /// <summary>
        /// Pointer to description to use when creating debug messenger.
        /// If NULL, default internal description will be used,
        /// together with the following messageSeverity and messageCategory fields.
        /// </summary>
        public NvImgCodecDebugMessengerDesc DebugMessengerDesc;

        public uint MessageSeverity;                    // Severity for default debug messenger.
        public uint MessageCategory;                    // Message category for default debug messenger.
    }

}
