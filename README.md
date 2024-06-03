# File Enumerator and Metadata Logger

A console application that enumerates files in a given directory, logs their metadata to a history file, and provides an option to delete the files.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Installation

Follow these steps to install and run the project.

### Prerequisites

- .NET SDK 8.0 or later

### Steps

1. Clone the repository:
    ```sh
    git clone https://github.com/your-username/file-enumerator.git
    ```
2. Navigate to the project directory:
    ```sh
    cd file-enumerator
    ```
3. Restore the dependencies:
    ```sh
    dotnet restore
    ```
4. Build the project:
    ```sh
    dotnet build
    ```
5. Run the project:
    ```sh
    dotnet run
    ```

## Usage

The application prompts the user to enter a directory path and logs metadata of the files in that directory.

### Example

1. Run the application:
    ```sh
    dotnet run
    ```

2. Enter the directory path when prompted:
    ```plaintext
    Enter File/s Directory: C:\path\to\directory
    ```

This command will:
1. Enumerate all files in the specified directory.
2. Log their metadata (full name, name, size in MB, and last write time) to a file named `Log.txt` in the `output` directory.
3. The log file will be named with a timestamp to ensure uniqueness.

## Features

- Prompt the user to enter a directory path.
- Enumerate files in the specified directory.
- Log file metadata to a timestamped log file.
- Create the output directory if it does not exist.

## Contributing

This is a simple passion project and is currently not open for contributions. However, if you find any issues or have suggestions, feel free to open an issue on GitHub. 

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

- Xerxis Tan - [@iamxerxis](https://twitter.com/iamxerxis) - iamxerxis@yahoo.com
- Project Link: [https://github.com/iamecks/files-to-delete-enumerator](https://github.com/iamecks/files-to-delete-enumerator)
