﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina'</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using RawCMS.Library.Core;
using System.Collections.Generic;

namespace RawCMS.Library.JavascriptClient
{
    public class JavascriptRestClientMessage<T>
    {
        public List<Error> Errors { get; set; } = new List<Error>();
        public List<Error> Warnings { get; set; } = new List<Error>();
        public List<Error> Infos { get; set; } = new List<Error>();

        public RestStatus Status { get; set; }

        public T Data { get; set; }

        public JavascriptRestClientMessage(T item)
        {
            Data = item;
        }
    }
}