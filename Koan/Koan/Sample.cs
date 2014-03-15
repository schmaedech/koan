﻿/*M///////////////////////////////////////////////////////////////////////////////////////
//
//  IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING.
//
//  By downloading, copying, installing or using the software you agree to this license.
//  If you do not agree to this license, do not download, install,
//  copy or use the software.
//
//
//                           License Agreement
//                For Open Source Heart Rate SCADA Library  
//
// Copyright (C) 2011-2012, Diego Schmaedech, all rights reserved. 
//
							For Open Source Biosignal SCADA
//
// Copyright (C) 2012, Laboratório de Educação Cerebral, all rights reserved.
//
// Third party copyrights are property of their respective owners.
// Third party copyrights are property of their respective owners.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
//   * Redistribution's of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//
//   * Redistribution's in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//
//   * The name of the copyright holders may not be used to endorse or promote products
//     derived from this software without specific prior written permission.
//
// This software is provided by the copyright holders and contributors "as is" and
// any express or implied warranties, including, but not limited to, the implied
// warranties of merchantability and fitness for a particular purpose are disclaimed.
// In no event shall the Intel Corporation or contributors be liable for any direct,
// indirect, incidental, special, exemplary, or consequential damages
// (including, but not limited to, procurement of substitute goods or services;
// loss of use, data, or profits; or business interruption) however caused
// and on any theory of liability, whether in contract, strict liability,
// or tort (including negligence or otherwise) arising in any way out of
// the use of this software, even if advised of the possibility of such damage.
//
//M*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioSCADA
{
    public class Sample
    {
        public string Login;
        public string Timestamp;
        public string Batery;
        public string BPM;
        public string RR;
        public string Coherence;
        public string TAG;

        public Sample() { }

        public Sample(string login, string timestamp, string batery, string bpm, string rr, string coherence, string tag)
        {

            Login = login;
            Timestamp = timestamp;
            Batery = batery;
            BPM = bpm;
            RR = rr;
            Coherence = coherence;
            TAG = tag;
        }

        public override string ToString()
        {

            return "<?xml version='1.0' encoding='utf-8'?> <Samples><Sample><Login>" + Login + "</Login><Timestamp>" + Timestamp + "</Timestamp> <Batery>" + Batery + "</Batery>  <BPM>" + BPM + "</BPM> <RR>" + RR + "</RR>  <Coherence>" + Coherence + "</Coherence> <TAG>" + TAG + "</TAG></Sample></Samples>";

  
        }
    }

    public class Samples : ICollection
    {
        public string CollectionName;
        private ArrayList empArray = new ArrayList();

        public Sample this[int index]
        {
            get { return (Sample)empArray[index]; }
        }

        public void CopyTo(Array a, int index)
        {
            empArray.CopyTo(a, index);
        }
        public int Count
        {
            get { return empArray.Count; }
        }
        public object SyncRoot
        {
            get { return this; }
        }
        public bool IsSynchronized
        {
            get { return false; }
        }
        public IEnumerator GetEnumerator()
        {
            return empArray.GetEnumerator();
        }

        public void Add(Sample newSample)
        {
            empArray.Add(newSample);
        }
    }

}