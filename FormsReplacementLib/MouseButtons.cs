﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FormsReplacementLib
{
    public enum MouseButtons
    {
        /// <include file='doc\MouseButtons.uex' path='docs/doc[@for="MouseButtons.Left"]/*' />
        /// <devdoc>
        ///    <para>
        ///
        ///       The left mouse button was pressed.
        ///
        ///    </para>
        /// </devdoc>
        Left = 0x00100000,

        /// <include file='doc\MouseButtons.uex' path='docs/doc[@for="MouseButtons.None"]/*' />
        /// <devdoc>
        ///    <para>
        ///
        ///       No mouse button was pressed.
        ///
        ///    </para>
        /// </devdoc>
        None = 0x00000000,

        /// <include file='doc\MouseButtons.uex' path='docs/doc[@for="MouseButtons.Right"]/*' />
        /// <devdoc>
        ///    <para>
        ///
        ///       The right mouse button was pressed.
        ///
        ///    </para>
        /// </devdoc>
        Right = 0x00200000,

        /// <include file='doc\MouseButtons.uex' path='docs/doc[@for="MouseButtons.Middle"]/*' />
        /// <devdoc>
        ///    <para>
        ///
        ///       The middle mouse button was pressed.
        ///
        ///    </para>
        /// </devdoc>
        Middle = 0x00400000,

        /// <include file='doc\MouseButtons.uex' path='docs/doc[@for="MouseButtons.XButton1"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        XButton1 = 0x00800000,

        /// <include file='doc\MouseButtons.uex' path='docs/doc[@for="MouseButtons.XButton2"]/*' />
        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        XButton2 = 0x01000000,
    }
}