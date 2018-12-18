# Media Manager (NASA Mars rover image utility)
An open ended utility for downloading images from NASA API. Designed to potentially extend to manage all types of media from a variety of sources.

## Requirements
As stated, the requirements of this utility are,

1. Get input dates from unstructured text documentation
2. Download images from NASA API (starting with Mars Rove) according to input

## Design
Media Manager is a simple utility to download media from provided API. The API service is structured to be extensible to other Nasa API or other RESTful API. Future implementations could use dependency injection to handle CRUD actions (including both uploads and downloads). Media Manager also features a logging service implementing the singleton pattern.

## Dependencies
Media Manager uses Newtonsoft for deserialization of JSON responses.

## Deployment and Execution
For local execution of Media Manager, run Program.cs in the root directory of the solution.

* Source file should be loaded into /Input directory with title of mars_rover_dates.txt
* Downloaded photos will be output to the /Output directory, sorted by date.
* Log file will be output to the /Logs directory.

## License
Copyright 2018 - Tyler Fluegel

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
