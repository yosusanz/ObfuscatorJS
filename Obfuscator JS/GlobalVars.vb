Imports System.Reflection

Module GlobalVars
    Public Const APP_NAME As String = "Obfuscator JS"
    Public ReadOnly APP_VERSION As Version = Assembly.GetExecutingAssembly().GetName().Version
    Public ReadOnly APP_DIRECTORY As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)

    Public Const NODE_PORTABLE_URL As String = "https://nodejs.org/dist/v20.14.0/node-v20.14.0-win-x64.zip"

    Public Const NPM_PORTABLE As String = "
            @echo off
            setlocal

            set ""NODE_DIR=%~dp0""
            set ""PATH=%NODE_DIR%;%PATH%""

            call ""%NODE_DIR%npm.cmd"" %*"

    Public JS_OBFUSCATOR As String = "
            const fs = require('fs');
            const path = require('path');
            const JavaScriptObfuscator = require('" & APP_DIRECTORY.Replace("\", "/") & "/node/node_modules/javascript-obfuscator');

            const inputPath = process.argv[2];
            const outputPath = process.argv[3];

            if (!inputPath || !outputPath) {
              console.error('Usage: node obfuscate.js <inputFile> <outputFile>');
              process.exit(1);
            }

            const code = fs.readFileSync(inputPath, 'utf8');
            const result = JavaScriptObfuscator.obfuscate(code, {
              compact: true,
              controlFlowFlattening: true
            });
            fs.writeFileSync(outputPath, result.getObfuscatedCode());
            console.log('Obfuscation done');
"
End Module
