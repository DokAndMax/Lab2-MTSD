# Doubly linked list with unit tests

This program is made to demonstrate the opportunities of my custom-implemented Doubly linked list. It has unit tests that cover various aspects of the list's functionality.

## Розрахунок номеру варіанту та опис варіанту
**1219** % **4** = **3** варіант

| остача | початкова реалізація списку | друга реалізація списку |
|:---------:|:---------:|:------------:|
| 3 | список на базі вбудованих масивів/списків | двобічно зв'язаний список |


## How to build
#### 1. Clone the repository
- Download and install Git from the official site.
- Clone the repository from GitHub using the `git clone <url>` command from the command line or terminal. The URL can be found on the repository page on GitHub.

#### 2. Install the required software
- Download and install the ***.NET 7 SDK*** from the official Microsoft website.
- Install any code editor such as **Visual Studio Code** or **Visual Studio**.

#### 3. Assemble the project
- Open a command prompt or terminal and navigate to the project code folder.
- Run the `dotnet restore` command to install all project dependencies.
- Run the `dotnet build` command to build the project.

#### 4. Run the tests
- Run the `dotnet test` command to run the tests.

### My [Commit that breaks unit test](https://github.com/DokAndMax/Lab2-MTSD/commit/91247b55c1069ac9562fc8750804ab1d65bf9358)

## Висновок
Unit-тести дуже зручні в випадку коли треба задати гарантовану поведінку функції і в подальшому спиратися на неї. Це дозволяє не писати кожен раз тимчасові строчки і не запускати проєкт тільки за для перевірки працездатності однієї функції. Дійсно, розробляти програму та вносити правки зі заздалегідь написаними unit-тестами **легше**.
