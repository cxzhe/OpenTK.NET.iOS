using System;

namespace OpenTK.Graphics.ES10
{
    /// <summary>
    /// Provides access to OpenGL ES 1.0 methods.
    /// </summary>
    public sealed partial class GL : GraphicsBindingsBase
    {
        const string Library = @"System/Library/Frameworks/OpenGLES.framework/OpenGLES";//"libGLES";
        static readonly object sync_root = new object();

        #region --- Protected Members ---

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        #endregion

    }
}
