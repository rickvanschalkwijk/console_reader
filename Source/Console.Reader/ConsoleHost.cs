﻿using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using Console.Reader.Business.Readers.Interfaces;
using Console.Reader.Common.Extensions;

using StructureMap;

namespace Console.Reader
{
    public class ConsoleHost
    {
        private readonly TextReader _textReader;

        private readonly TextWriter _textWriter;

        private readonly IDirectoryReader _directoryReader;

        public ConsoleHost(TextReader textReader, TextWriter textWriter)
        {
            Ensure.ArgumentNotNull(textReader, "TextReader");
            Ensure.ArgumentNotNull(textWriter, "TextReader");

            _textReader = textReader;
            _textWriter = textWriter;

            string whatDoIHave = ObjectFactory.Container.WhatDoIHave();

            _directoryReader = ObjectFactory.GetInstance<IDirectoryReader>();
        }
        public void Run()
        {
            InitConsoleWindow();
            _textWriter.WriteLine("Hello there, welcome to Console Reader........");
            var fvi = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            _textWriter.WriteLine(string.Format("You're running v{0}", fvi.FileVersion));

            _textWriter.WriteLine();
            bool result = true;

            while (result)
            {
                string command = Prompt();
                result = Process(command);
            }
        }

        private void InitConsoleWindow()
        {
            System.Console.SetWindowPosition(0, 0);
            System.Console.Title = "Console Reader";
            System.Console.WindowWidth = 100;
            System.Console.WindowHeight = 75;
        }

        private string Prompt()
        {
            _textWriter.Write("Console Reader> ");
            return _textReader.ReadLine();
        }

        private bool Process(string command)
        {
            List<string> filesPaths = _directoryReader.ProcessDirectory("../../../../StaticSource/");
            _textWriter.WriteLine("Number of files in the directory: {0}", _directoryReader.CountFilesInDirectory("../../../../StaticSource/"));
            return true;
        }
    }
}
