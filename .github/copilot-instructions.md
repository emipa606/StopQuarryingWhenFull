# GitHub Copilot Instructions for RimWorld Modding Project

## Mod Overview and Purpose

The "Stop Quarrying When Full" mod is designed for RimWorld, a popular colony simulation game. Its primary purpose is to enhance the gameplay experience by improving a specific in-game mechanic: quarrying. The mod automatically stops colonists from quarrying when storage is full, preventing wasted effort and ensuring a more efficient resource collection and management system.

## Key Features and Systems

- **Automatic Quarry Management:** The mod introduces a mechanism to halt quarrying activities when the designated storage is full, ensuring that resources are not wasted due to lack of space.
- **User Settings Integration:** Players can configure the mod's behavior through in-game settings, allowing customization to fit various play styles or colony needs.
- **Inspection String Patches:** The mod provides detailed inspection strings for quarries, giving players clear feedback on the status of their mining operations.

## Coding Patterns and Conventions

- **Code Structure:** The project uses a combination of internal and public static classes to organize functionality based on purpose and accessibility.
- **Naming Conventions:** Classes and methods utilize PascalCase, reflecting common C# conventions.
- **Modular Design:** Each file is focused on a specific part of the mod's functionality, maintaining clarity and ease of maintenance.

## XML Integration

While the summary did not include specific XML integration aspects, standard XML practices in RimWorld modding may involve:

- **Defining Custom Defs:** Ensure any new game objects or modifications are correctly defined in XML.
- **Patching Existing Defs:** Use XML patch operations to modify existing game functionality in a non-destructive manner.

## Harmony Patching

- The mod makes use of Harmony, a popular library for patching C# applications, to alter the game's behavior:
  - **Class: `Building_Quarry_GetInspectString_Patch`:** Intercepts and modifies the inspection string for quarries.
  - **Class: `WorkGiver_MineQuarry_JobOnThing_Patch`:** Influences the job assignments to consider storage capacity before allowing quarrying tasks.
- Harmony allows for non-invasive changes to game code, providing a robust way to add or change game logic.

## Suggestions for Copilot

To aid in development, Copilot could assist by:

- **Generating Boilerplate Code:** Creating new classes or methods consistent with existing style and conventions.
- **Writing Harmony Patches:** Offer templates for patching methods using Harmony, especially for common patterns like prefix, postfix, and transpiler methods.
- **XML Template Generation:** Suggesting standard XML snippets for defining new game objects or modifying existing ones.
- **Refactoring Suggestions:** Identifying opportunities for code simplification or performance improvement.

By leveraging GitHub Copilot, developers can streamline the modding process, reduce repetitive tasks, and focus on creating unique and fun enhancements for RimWorld.
