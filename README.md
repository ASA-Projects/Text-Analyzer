# Text Analyzer GUI

A C# Windows Forms application designed to parse and analyze text inputs. The application processes raw text to extract core structural statistics and generates a detailed frequency dictionary of all words used.

## Features

* **Statistical Breakdown:** Instantly calculates and displays:
  * Total number of sentences.
  * Total word count.
  * Number of unique words.
* **Frequency Dictionary:** Generates a dynamic, sortable list displaying every unique word found in the text alongside its exact occurrence count.
* **Automated Data Sanitization:** Strips common punctuation (`.,:;?!'"`) to ensure accurate tokenization and word counting.
* **Clean Architecture:** Utilizes a dedicated `TextAnalysis` backend class to handle all string manipulation and dictionary generation, keeping the UI logic clean and decoupled.

## Technologies Used

* **Language:** C#
* **Framework:** .NET 6.0
* **UI:** Windows Forms (WinForms)
* **IDE:** Visual Studio 2022

## Architecture: The `TextAnalysis` Engine

The core logic of the application is isolated in the `TextAnalysis.cs` class. Upon instantiation with a string of text, it automatically executes the `Analyze()` method. 

1. **Sentence Counting:** Scans the raw string for sentence-ending punctuation (`.;!?`).
2. **Sanitization:** Removes all defined punctuation characters to isolate raw words.
3. **Tokenization:** Splits the cleaned text into an array of strings, filtering out any whitespace.
4. **Dictionary Mapping:** Iterates through the tokens, populating a `Dictionary<string, int>` where the key is the word and the value is its frequency count.

## Getting Started

### Prerequisites
* Visual Studio 2022 (or later) with the ".NET desktop development" workload installed.
* .NET 6.0 SDK.

### Installation & Execution
1. Clone the repository to your local machine.
2. Open the solution file (`16Lab2Solution.sln`) in Visual Studio.
3. Ensure `16Lab2` is set as the startup project.
4. Press `F5` or click **Start** to build and run the application.

## Usage
1. Launch the application.
2. Paste or type your text into the main input box.
3. Click the **Analyze** button.
4. View the statistical breakdown in the lower right panel and the word frequency dictionary in the list view.
5. Click **Exit** to close the application.
