# Gilded Rose Refactoring Task

## Compilation and Execution

### Prerequisites

- .NET Framework 4.5+
  
### Compiling and Running

1. Clone the repository:

   ```bash
   git clone https://github.com/CMolero/GildedRose.git
   ```

2. Open a terminal and navigate to the project directory.

3. Compile the code using the following command:

   ```bash
   dotnet build
   ```

4. If there are no errors during the build the project should automatically run and you should see the results in the terminal screen.


## Explanation of Choices

1. **Modular Approach:** The code is organized into separate methods for handling different item categories. This modular approach enhances code readability, maintainability, and allows easy extension for new item categories.

2. **Quality Bounds:** The quality of items is always constrained within the range of 0 to 50, as specified in the requirements. This is enforced after each quality update.

3. **Specific Item Handling:** Special items like "Aged Brie", "Backstage Passes", and "Conjured" items are explicitly handled in dedicated methods. This improves code clarity and makes it easier to add specific logic for each item type.

4. **Legendary Item Handling:** The quality and sell-by date of "Sulfuras" are not updated, as it is a legendary item with fixed attributes. This is checked at the beginning of the `UpdateQuality` method.

5. **Newly Introduced Item Category:** The "Conjured" item category is introduced with its own quality update logic, degrading twice as fast as normal items.

6. **README.md:** A detailed README file is included to guide users through compiling and running the code. It provides clear instructions and prerequisites for a smooth execution experience.

