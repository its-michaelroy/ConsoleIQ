# ConsoleIQ

A console-based quiz application that allows users to test their knowledge on various topics. Built with C#, **ConsoleIQ** demonstrates key software development principles, including object-oriented programming, data serialization, and user interaction in a console environment.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Future Development](#future-development)
- [Contributing](#contributing)
- [License](#license)

---

## Introduction

**ConsoleIQ** is a C# console application that presents quizzes to users on a variety of topics. Users can select a topic, answer questions, and receive immediate feedback along with a final score and percentage. The application reads quiz questions from a JSON file, making it easy to add or modify quiz content.

---

## Features

- **Multiple Topics**: Users can select from various quiz topics.  
- **Multiple Question Types**: Supports both basic and multiple-choice questions.  
- **Randomized Questions**: Questions are shuffled to provide a unique experience every time.  
- **Immediate Feedback**: Users receive feedback right after each question.  
- **Scoring System**: Displays the final score and percentage at the end of the quiz.  
- **Extensible Design**: Easy to add new topics and questions via the JSON file.  
- **Object-Oriented Design**: Utilizes inheritance and polymorphism (e.g., `Question` and `MultipleChoiceQuestion` classes).

---

## Technologies Used

- **C#**: The programming language used to develop the application.  
- **.NET 8.0 SDK**: Framework for building and running the application.  
- **Console Application**: Interacts with users via the console.  
- **JSON Serialization**: Uses `System.Text.Json` to read quiz data from JSON files.

---

## Prerequisites

- **Operating System**: Windows, macOS, or Linux  
- **.NET 8.0 SDK**: [Download and install](https://dotnet.microsoft.com/download/dotnet/8.0)  
- **IDE/Text Editor (Optional)**: Visual Studio 2022, Visual Studio Code, or another code editor of your choice.

---

## Installation

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/yourusername/ConsoleIQ.git
   ```

2. **Navigate to the Project Directory**  
   ```bash
   cd ConsoleIQ
   ```

3. **Restore Dependencies**  
   ```bash
   dotnet restore
   ```

4. **Build the Project**  
   ```bash
   dotnet build
   ```

5. **Configure `QuestionSet.json` File**  
   Ensure that the `QuestionSet.json` file is correctly set up to be included in the build process.

   - **Using Visual Studio**:  
     1. Right-click on `QuestionSet.json` in the **Solution Explorer**.  
     2. Select **Properties**.  
     3. Set **Build Action** to `Content`.  
     4. Set **Copy to Output Directory** to `Copy if newer`.

   - **Using Command Line or Other Editors**:  
     1. Verify that your `.csproj` file includes the following:

       ```xml
       <ItemGroup>
         <Content Include="QuestionSet.json">
           <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
         </Content>
       </ItemGroup>
       ```

---

## Usage

To run the application, use the following command from the root directory:

```bash
dotnet run --project ConsoleIQ/ConsoleIQ.csproj
```

Alternatively, if you are already in the `ConsoleIQ` directory, you can simply run:

```bash
dotnet run
```

### Running in Visual Studio

1. Open `ConsoleIQ.sln` in Visual Studio 2022.  
2. Press **F5** to run the application with debugging, or **Ctrl + F5** to run without debugging.

### Application Flow

1. **Welcome Message**: Upon starting, the application displays a welcome message.  
2. **Select a Topic**: You are presented with a list of quiz topics. Enter the number corresponding to the desired topic.  
3. **Answer Questions**: Questions will be displayed one at a time. For multiple-choice questions, options are listed. You can enter either the option number or the exact answer.  
4. **Receive Feedback**: After each question, you are informed if your answer was correct or incorrect.  
5. **View Final Score**: At the end of the quiz, your total score and percentage are displayed.

---

## Project Structure

```
ConsoleIQ/
├── ConsoleIQ.sln               # Visual Studio solution file
├── ConsoleIQ.csproj            # Project file
├── Program.cs                  # Entry point of the application
├── ManagerLogic/
│   └── QuizManager.cs          # Handles quiz operations
├── Models/
│   ├── Question.cs             # Base class for questions
│   ├── MultipleChoiceQuestion.cs  # Derived class for multiple-choice questions
│   └── RawQuestion.cs          # Represents questions deserialized from JSON
├── QuestionSet.json            # JSON file containing quiz questions
├── README.md                   # Project documentation
├── bin/                        # Build outputs
└── obj/                        # Build intermediates
```

---

## Future Development

- **User Interface Enhancements**: Improve the console UI with colors and better formatting for readability.  
- **Additional Question Types**: Incorporate true/false, fill-in-the-blank, and other question formats.  
- **Timed Quizzes**: Implement a timer for each question to increase the challenge.  
- **High Score Tracking**: Provide persistent storage to track high scores between sessions.  
- **User Profiles**: Allow users to create profiles and track their progress over time.  
- **Cross-Platform GUI Version**: Develop a graphical user interface using .NET MAUI or WPF.  
- **Localization**: Support multiple languages for international users.

---

## Contributing

(Contributing guidelines to be added.)

---

## License

(License information to be added.)

---

*Enjoy!*