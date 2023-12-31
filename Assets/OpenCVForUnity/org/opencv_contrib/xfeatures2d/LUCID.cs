﻿
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class LUCID
    /**
     * Class implementing the locally uniform comparison image descriptor, described in CITE: LUCID
     *
     * An image descriptor that can be computed very fast, while being
     * about as robust as, for example, SURF or BRIEF.
     *
     * <b>Note:</b> It requires a color image as input.
     */

    public class LUCID : Feature2D
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        xfeatures2d_LUCID_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal LUCID(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new LUCID __fromPtr__(IntPtr addr) { return new LUCID(addr); }

        //
        // C++: static Ptr_LUCID cv::xfeatures2d::LUCID::create(int lucid_kernel = 1, int blur_kernel = 2)
        //

        /**
         * param lucid_kernel kernel for descriptor construction, where 1=3x3, 2=5x5, 3=7x7 and so forth
         * param blur_kernel kernel for blurring image prior to descriptor construction, where 1=3x3, 2=5x5, 3=7x7 and so forth
         * return automatically generated
         */
        public static LUCID create(int lucid_kernel, int blur_kernel)
        {


            return LUCID.__fromPtr__(xfeatures2d_LUCID_create_10(lucid_kernel, blur_kernel));


        }

        /**
         * param lucid_kernel kernel for descriptor construction, where 1=3x3, 2=5x5, 3=7x7 and so forth
         * return automatically generated
         */
        public static LUCID create(int lucid_kernel)
        {


            return LUCID.__fromPtr__(xfeatures2d_LUCID_create_11(lucid_kernel));


        }

        /**
         * return automatically generated
         */
        public static LUCID create()
        {


            return LUCID.__fromPtr__(xfeatures2d_LUCID_create_12());


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_LUCID cv::xfeatures2d::LUCID::create(int lucid_kernel = 1, int blur_kernel = 2)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_10(int lucid_kernel, int blur_kernel);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_11(int lucid_kernel);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_LUCID_delete(IntPtr nativeObj);

    }
}
