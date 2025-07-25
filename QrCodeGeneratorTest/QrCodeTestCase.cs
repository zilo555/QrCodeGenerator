﻿/* 
 * QR code generator library (.NET)
 *
 * Copyright (c) Manuel Bleichenbacher (MIT License)
 * https://github.com/manuelbl/QrCodeGenerator
 * Copyright (c) Project Nayuki (MIT License)
 * https://www.nayuki.io/page/qr-code-generator-library
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
 * IN THE SOFTWARE.
 */

using System.Collections.Generic;
using static Net.Codecrete.QrCodeGenerator.QrCode;

namespace Net.Codecrete.QrCodeGenerator.Test
{
    public class QrCodeTestCase
    {
        public int Index { get; set; }
        public List<QrSegment> Segments { get; set; }
        public string[] ExpectedModules { get; set; }
        public Ecc RequestedEcc { get; set; }
        public int MinVersion { get; set; }
        public int MaxVersion { get; set; }
        public int RequestedMask { get; set; }
        public bool BoostEcl { get; set; }
        public Ecc EffectiveEcc { get; set; }
        public int EffectiveVersion { get; set; }
        public int EffectiveMask { get; set; }

        public QrCodeTestCase(int index, List<QrSegment> segments, string[] expectedModules,
            Ecc requestedEcc, int minVersion, int maxVersion, int requestedMask, bool boostEcl,
            Ecc effectiveEcc, int effectiveVersion,  int effectiveMask)
        {
            Index = index;
            Segments = segments;
            ExpectedModules = expectedModules;
            RequestedEcc = requestedEcc;
            MinVersion = minVersion;
            MaxVersion = maxVersion;
            RequestedMask = requestedMask;
            BoostEcl = boostEcl;
            EffectiveEcc = effectiveEcc;
            EffectiveVersion = effectiveVersion;
            EffectiveMask = effectiveMask;
        }

        public override string ToString()
        {
            return $"Case {Index}";
        }
    }
}
