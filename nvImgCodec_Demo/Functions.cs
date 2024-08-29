using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NvImgCodec
{
    public static class Functions
    {
        private const string DllName = "nvimgcodec_0.dll"; // The name of the DLL

        /// <summary>
        /// Extension shared module exported entry function.
        /// </summary>
        /// <param name="extDesc">Points to a nvimgcodecExtensionDesc handle in which the extension description is returned.</param>
        /// <returns>Returns nvimgcodecStatus_t - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl,EntryPoint = "nvimgcodecExtensionModuleEntry")]
        public static extern NvImgCodecStatus NvImgCodecExtensionModuleEntry(ref NvImgCodecExtensionDesc extDesc);

        /// <summary>
        /// Provides nvImageCodec library properties.
        /// </summary>
        /// <param name="properties">Points to a nvimgcodecProperties handle in which the properties are returned.</param>
        /// <returns>Returns nvimgcodecStatus_t - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecGetProperties")]
        public static extern NvImgCodecStatus NvImgCodecGetProperties(ref NvImgCodecProperties properties);

        /// <summary>
        /// Creates an instance of the library using the input arguments.
        /// </summary>
        /// <param name="instance">Points to a NvImgCodecInstance handle in which the resulting instance is returned.</param>
        /// <param name="createInfo">Pointer to a NvImgCodecInstanceCreateInfo structure controlling creation of the instance.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecInstanceCreate")]
        public static extern NvImgCodecStatus NvImgCodecInstanceCreate(
            ref NvImgCodecInstance instance,
            [In] ref NvImgCodecInstanceCreateInfo createInfo);

        /// <summary>
        /// Destroys the nvImageCodec library instance.
        /// </summary>
        /// <param name="instance">The library instance handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecInstanceDestroy")]
        public static extern NvImgCodecStatus NvImgCodecInstanceDestroy(NvImgCodecInstance instance);

        /// <summary>
        /// Creates library extension.
        /// </summary>
        /// <param name="instance">The library instance handle the extension will be used with.</param>
        /// <param name="extension">Points to a NvImgCodecExtension handle in which the resulting extension is returned.</param>
        /// <param name="extensionDesc">Pointer to a NvImgCodecExtensionDesc structure which defines extension to create.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecExtensionCreate")]
        public static extern NvImgCodecStatus NvImgCodecExtensionCreate(
            NvImgCodecInstance instance,
            ref NvImgCodecExtension extension,
            [In] ref NvImgCodecExtensionDesc extensionDesc);

        /// <summary>
        /// Destroys library extension.
        /// </summary>
        /// <param name="extension">The extension handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecExtensionDestroy")]
        public static extern NvImgCodecStatus NvImgCodecExtensionDestroy(NvImgCodecExtension extension);

        /// <summary>
        /// Creates a debug messenger.
        /// </summary>
        /// <param name="instance">The library instance handle the messenger will be used with.</param>
        /// <param name="dbgMessenger">Points to a NvImgCodecDebugMessenger handle in which the resulting debug messenger is returned.</param>
        /// <param name="messengerDesc">Pointer to NvImgCodecDebugMessengerDesc structure which defines debug messenger to create.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecDebugMessengerCreate")]
        public static extern NvImgCodecStatus NvImgCodecDebugMessengerCreate(
            NvImgCodecInstance instance,
            ref NvImgCodecDebugMessenger dbgMessenger,
            [In] ref NvImgCodecDebugMessengerDesc messengerDesc);

        /// <summary>
        /// Destroys debug messenger.
        /// </summary>
        /// <param name="dbgMessenger">The debug messenger handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecDebugMessengerDestroy")]
        public static extern NvImgCodecStatus NvImgCodecDebugMessengerDestroy(NvImgCodecDebugMessenger dbgMessenger);

        /// <summary>
        /// Waits for processing items to be finished.
        /// </summary>
        /// <param name="future">Handle to future object created by decode or encode functions.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        /// <remarks>
        /// Please note that when future is ready, it only means that all host work was done and it can be that
        /// some work was scheduled to be executed on device (depending on codec). To further synchronize work on 
        /// device, there is cuda_stream field available in NvImgCodecImageInfo structure which can be used to specify 
        /// cuda_stream to synchronize with.
        /// </remarks>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecFutureWaitForAll")]
        public static extern NvImgCodecStatus NvImgCodecFutureWaitForAll(NvImgCodecFuture future);

        /// <summary>
        /// Destroys future.
        /// </summary>
        /// <param name="future">The future handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecFutureDestroy")]
        public static extern NvImgCodecStatus NvImgCodecFutureDestroy(NvImgCodecFuture future);

        /// <summary>
        /// Receives processing statuses of batch items scheduled for decoding or encoding.
        /// </summary>
        /// <param name="future">The future handle returned by decode or encode function for given batch items.</param>
        /// <param name="processingStatus">Points to a NvImgCodecProcessingStatus handle in which the processing statuses is returned.</param>
        /// <param name="size">Points to size_t in which the size of processing statuses returned.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecFutureGetProcessingStatus")]
        public static extern NvImgCodecStatus NvImgCodecFutureGetProcessingStatus(
            NvImgCodecFuture future,
            [Out] out NvImgCodecProcessingStatus processingStatus,
            [Out] out IntPtr size);

        /// <summary>
        /// Creates an image which wraps sample buffer together with format information.
        /// </summary>
        /// <param name="instance">The library instance handle the image will be used with.</param>
        /// <param name="image">Points to a NvImgCodecImage handle in which the resulting image is returned.</param>
        /// <param name="imageInfo">Points to a NvImgCodecImageInfo struct which describes sample buffer together with format.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecImageCreate")]
        public static extern NvImgCodecStatus NvImgCodecImageCreate(
            NvImgCodecInstance instance,
            ref NvImgCodecImage image,
            [In] ref NvImgCodecImageInfo imageInfo);

        /// <summary>
        /// Destroys the image.
        /// </summary>
        /// <param name="image">The image handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecImageDestroy")]
        public static extern NvImgCodecStatus NvImgCodecImageDestroy(NvImgCodecImage image);

        /// <summary>
        /// Retrieves image information from provided opaque image object.
        /// </summary>
        /// <param name="image">The image handle to retrieve information from.</param>
        /// <param name="imageInfo">Points to a NvImgCodecImageInfo handle in which the image information is returned.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecImageGetImageInfo")]
        public static extern NvImgCodecStatus NvImgCodecImageGetImageInfo(
            NvImgCodecImage image,
            ref NvImgCodecImageInfo imageInfo);

        /// <summary>
        /// Creates a code stream which wraps a file source of compressed data.
        /// </summary>
        /// <param name="instance">The library instance handle the code stream will be used with.</param>
        /// <param name="codeStream">Points to a NvImgCodecCodeStream handle in which the resulting code stream is returned.</param>
        /// <param name="fileName">File name with compressed image data to wrap.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecCodeStreamCreateFromFile")]
        public static extern NvImgCodecStatus NvImgCodecCodeStreamCreateFromFile(
            NvImgCodecInstance instance,
            ref NvImgCodecCodeStream codeStream,
            [MarshalAs(UnmanagedType.LPStr)] string fileName);

        /// <summary>
        /// Creates a code stream which wraps host memory source of compressed data.
        /// </summary>
        /// <param name="instance">The library instance handle the code stream will be used with.</param>
        /// <param name="codeStream">Points to a NvImgCodecCodeStream handle in which the resulting code stream is returned.</param>
        /// <param name="data">Pointer to buffer with compressed data.</param>
        /// <param name="length">Length of compressed data in provided buffer.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecCodeStreamCreateFromHostMem")]
        public static extern NvImgCodecStatus NvImgCodecCodeStreamCreateFromHostMem(
            NvImgCodecInstance instance,
            ref NvImgCodecCodeStream codeStream,
            [MarshalAs(UnmanagedType.LPArray)] byte[] data,
            UIntPtr length);

        /// <summary>
        /// Creates a code stream which wraps a file sink for compressed data with the given format.
        /// </summary>
        /// <param name="instance">The library instance handle the code stream will be used with.</param>
        /// <param name="codeStream">Points to a NvImgCodecCodeStream handle in which the resulting code stream is returned.</param>
        /// <param name="fileName">File name sink for compressed image data to wrap.</param>
        /// <param name="imageInfo">Points to a NvImgCodecImageInfo struct which describes output image format.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecCodeStreamCreateToFile")]
        public static extern NvImgCodecStatus NvImgCodecCodeStreamCreateToFile(
            NvImgCodecInstance instance,
            ref NvImgCodecCodeStream codeStream,
            [MarshalAs(UnmanagedType.LPStr)] string fileName,
            [In] ref NvImgCodecImageInfo imageInfo);

        /// <summary>
        /// Function type to resize and provide host buffer.
        /// </summary>
        /// <param name="ctx">Pointer to context provided together with function.</param>
        /// <param name="reqSize">Requested size of buffer.</param>
        /// <returns>Pointer to requested buffer.</returns>
        /// <note>This function can be called multiple times and requested size can be lower at the end so buffer can be shrunk.</note>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr NvImgCodecResizeBufferFunc(IntPtr ctx, UIntPtr reqSize);

        /// <summary>
        /// Creates a code stream which wraps host memory sink for compressed data with given format.
        /// </summary>
        /// <param name="instance">The library instance handle the code stream will be used with.</param>
        /// <param name="codeStream">Points to a NvImgCodecCodeStream handle in which the resulting code stream is returned.</param>
        /// <param name="ctx">Pointer to user-defined context with which get buffer function will be called back.</param>
        /// <param name="resizeBufferFunc">Points to a NvImgCodecResizeBufferFunc function handle which will be used to resize and provide host output buffer.</param>
        /// <param name="imageInfo">Points to a NvImgCodecImageInfo struct which describes output image format.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecCodeStreamCreateToHostMem")]
        public static extern NvImgCodecStatus NvImgCodecCodeStreamCreateToHostMem(
            NvImgCodecInstance instance,
            ref NvImgCodecCodeStream codeStream,
            IntPtr ctx,
            NvImgCodecResizeBufferFunc resizeBufferFunc,
            [In] ref NvImgCodecImageInfo imageInfo);

        /// <summary>
        /// Destroys the code stream.
        /// </summary>
        /// <param name="codeStream">The code stream handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecCodeStreamDestroy")]
        public static extern NvImgCodecStatus NvImgCodecCodeStreamDestroy(NvImgCodecCodeStream codeStream);

        /// <summary>
        /// Retrieves compressed image information from code stream.
        /// </summary>
        /// <param name="codeStream">The code stream handle to retrieve information from.</param>
        /// <param name="imageInfo">Points to a NvImgCodecImageInfo handle in which the image information is returned.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecCodeStreamGetImageInfo")]
        public static extern NvImgCodecStatus NvImgCodecCodeStreamGetImageInfo(
            NvImgCodecCodeStream codeStream,
            ref NvImgCodecImageInfo imageInfo);

        /// <summary>
        /// Creates a generic image decoder.
        /// </summary>
        /// <param name="instance">The library instance handle the decoder will be used with.</param>
        /// <param name="decoder">Points to a NvImgCodecDecoder handle in which the decoder is returned.</param>
        /// <param name="execParams">Points to execution parameters.</param>
        /// <param name="options">String with optional space-separated list of parameters for specific decoders in format "<decoder_id>:<parameter_name>=<parameter_value>". For example, "nvjpeg:fancy_upsampling=1".</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecDecoderCreate")]
        public static extern NvImgCodecStatus NvImgCodecDecoderCreate(
            NvImgCodecInstance instance,
            ref NvImgCodecDecoder decoder,
            [In] ref NvImgCodecExecutionParams execParams,
            [MarshalAs(UnmanagedType.LPStr)] string options);

        /// <summary>
        /// Destroys the decoder.
        /// </summary>
        /// <param name="decoder">The decoder handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecDecoderDestroy")]
        public static extern NvImgCodecStatus NvImgCodecDecoderDestroy(NvImgCodecDecoder decoder);

        /// <summary>
        /// Checks if the decoder can decode the provided code stream to given output images with specified parameters.
        /// </summary>
        /// <param name="decoder">The decoder handle to use for checks.</param>
        /// <param name="streams">Pointer to input NvImgCodecCodeStream array to check decoding with.</param>
        /// <param name="images">Pointer to output NvImgCodecImage array to check decoding with.</param>
        /// <param name="batchSize">Batch size of provided code streams and images.</param>
        /// <param name="params">Pointer to NvImgCodecDecodeParams struct to check decoding with.</param>
        /// <param name="processingStatus">Points to a NvImgCodecProcessingStatus handle in which the processing statuses are returned.</param>
        /// <param name="forceFormat">Valid values 0 or 1. If 1, and high priority codec does not support the provided format, it will fallback to a lower priority codec for further checks. For 0, when the high priority codec does not support the provided format or parameters but can process input in general, it will stop checking and return processing status with flags indicating what format or parameters need to be changed to avoid fallback to a lower priority codec.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecDecoderCanDecode")]
        public static extern NvImgCodecStatus NvImgCodecDecoderCanDecode(
            NvImgCodecDecoder decoder,
            [In] ref NvImgCodecCodeStream streams,
            [In] ref NvImgCodecImage images,
            int batchSize,
            [In] ref NvImgCodecDecodeParams param,
            ref NvImgCodecProcessingStatus processingStatus,
            int forceFormat);

        /// <summary>
        /// Decodes a batch of provided code streams to given output images with specified parameters.
        /// </summary>
        /// <param name="decoder">The decoder handle to use for decoding.</param>
        /// <param name="streams">Pointer to input NvImgCodecCodeStream array to decode.</param>
        /// <param name="images">Pointer to output NvImgCodecImage array to decode to.</param>
        /// <param name="batchSize">Batch size of provided code streams and images.</param>
        /// <param name="params">Pointer to NvImgCodecDecodeParams struct to decode with.</param>
        /// <param name="future">Points to a NvImgCodecFuture handle in which the future is returned. The future object can be used to wait and get processing statuses.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        /// <seealso cref="NvImgCodecFutureGetProcessingStatus"/>
        /// <seealso cref="NvImgCodecFutureWaitForAll"/>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecDecoderDecode")]
        public static extern NvImgCodecStatus NvImgCodecDecoderDecode(
            NvImgCodecDecoder decoder,
            [In] ref NvImgCodecCodeStream streams,
            [In] ref NvImgCodecImage images,
            int batchSize,
            [In] ref NvImgCodecDecodeParams param,
            ref NvImgCodecFuture future);

        /// <summary>
        /// Creates a generic image encoder.
        /// </summary>
        /// <param name="instance">The library instance handle the encoder will be used with.</param>
        /// <param name="encoder">Points to a NvImgCodecEncoder handle in which the encoder is returned.</param>
        /// <param name="execParams">Points to execution parameters.</param>
        /// <param name="options">String with optional, space-separated list of parameters for specific encoders, in format "<encoder_id>:<parameter_name>=<parameter_value>".</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecEncoderCreate")]
        public static extern NvImgCodecStatus NvImgCodecEncoderCreate(
            NvImgCodecInstance instance,
            ref NvImgCodecEncoder encoder,
            [In] ref NvImgCodecExecutionParams execParams,
            [MarshalAs(UnmanagedType.LPStr)] string options);

        /// <summary>
        /// Destroys the encoder.
        /// </summary>
        /// <param name="encoder">The encoder handle to destroy.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecEncoderDestroy")]
        public static extern NvImgCodecStatus NvImgCodecEncoderDestroy(NvImgCodecEncoder encoder);

        /// <summary>
        /// Checks if the encoder can encode the provided images to given output code streams with specified parameters.
        /// </summary>
        /// <param name="encoder">The encoder handle to use for checks.</param>
        /// <param name="images">Pointer to input NvImgCodecImage array to check encoding with.</param>
        /// <param name="streams">Pointer to output NvImgCodecCodeStream array to check encoding with.</param>
        /// <param name="batchSize">Batch size of provided code streams and images.</param>
        /// <param name="params">Pointer to NvImgCodecEncodeParams struct to check encoding with.</param>
        /// <param name="processingStatus">Points to a NvImgCodecProcessingStatus handle in which the processing statuses are returned.</param>
        /// <param name="forceFormat">Valid values 0 or 1. If 1, and high priority codec does not support the provided format, it will fallback to a lower priority codec for further checks. For 0, when the high priority codec does not support the provided format or parameters but can process input in general, it will stop checking and return processing status with flags indicating what format or parameters need to be changed to avoid fallback to a lower priority codec.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecEncoderCanEncode")]
        public static extern NvImgCodecStatus NvImgCodecEncoderCanEncode(
            NvImgCodecEncoder encoder,
            [In] ref NvImgCodecImage images,
            [In] ref NvImgCodecCodeStream streams,
            int batchSize,
            [In] ref NvImgCodecEncodeParams param,
            ref NvImgCodecProcessingStatus processingStatus,
            int forceFormat);

        /// <summary>
        /// Encodes a batch of provided images to given output code streams with specified parameters.
        /// </summary>
        /// <param name="encoder">The encoder handle to use for encoding.</param>
        /// <param name="images">Pointer to input NvImgCodecImage array to encode.</param>
        /// <param name="streams">Pointer to output NvImgCodecCodeStream array to encode to.</param>
        /// <param name="batchSize">Batch size of provided code streams and images.</param>
        /// <param name="params">Pointer to NvImgCodecEncodeParams struct to encode with.</param>
        /// <param name="future">Points to a NvImgCodecFuture handle in which the future is returned. The future object can be used to wait and get processing statuses.</param>
        /// <returns>Returns NvImgCodecStatus - An error code as specified in the API Return Status Codes.</returns>
        /// <seealso cref="NvImgCodecFutureGetProcessingStatus"/>
        /// <seealso cref="NvImgCodecFutureWaitForAll"/>
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvimgcodecEncoderEncode")]
        public static extern NvImgCodecStatus NvImgCodecEncoderEncode(
            NvImgCodecEncoder encoder,
            [In] ref NvImgCodecImage images,
            [In] ref NvImgCodecCodeStream streams,
            int batchSize,
            [In] ref NvImgCodecEncodeParams param,
            ref NvImgCodecFuture future);
    }
}
