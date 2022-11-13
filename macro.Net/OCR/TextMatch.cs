﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace macro.Net.OCR
{
    /// <summary>
    /// The result of an OCR (optical character recognition) text match.
    /// </summary>
    internal class TextMatch
    {
        public TextMatch()
        {
            SearchText = "";
            MatchedText = "";
        }

        /// <summary>
        /// The text that was originally searched for
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// The text that was found
        /// </summary>
        public string MatchedText { get; set; }

        /// <summary>
        /// The rectangle containing the matched text
        /// </summary>
        public Rect MatchRect { get; set; }

        public StringComparison NativeComparisonMethod { get; set; }

        // idea: develop a 'coarse' comparison method that matches strings even when some characters are missing or misidentified
    }

    /// <summary>
    /// Indicates whether there is an incomplete match, i.e.
    /// there might be more text to the right, left, or none at all (the match is complete).
    /// </summary>
    public enum Incomplete : ushort
    {
        None = 0,
        ToTheRight = 1,
        ToTheLeft = 2
    }
}