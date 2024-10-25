# Wizardworks --- programmeringsuppgift

## Uppgift
Skapa en webbsida som genererar potentiellt oändligt med kvadrater i en kvadratisk form. För varje knapptryckning på "Lägg till ruta" ska en ny ruta läggas till, och färgen på rutan ska slumpas fram (dock aldrig samma färg som föregående ruta).

## Funktionalitet

### Frontend:

- Byggs med React.js.
- Inget krav på CSS-ramverk, men TailwindCSS kan användas om så önskas.
- För varje klick på "Lägg till ruta" ska en slumpmässigt färgad ruta läggas till.

### Backend:

- Ett API byggs med .NET/C#.
- Vid varje knapptryckning ska position och färg på rutan sparas ner i en JSON-fil via API:et.
- När webbsidan laddas om, ska det tidigare tillståndet återläsas från API:et för att bibehålla state.

## Teknisk stack
- Frontend: React.js
- Backend: .NET/C#
- Lagring: JSON-fil via .NET API

## Flöde
En användare klickar på "Lägg till ruta", vilket triggar en händelse i React-applikationen som genererar en ny kvadrat.
Varje ruta får en slumpmässig färg som inte är samma som föregående ruta.
Position och färg på varje ruta skickas till API:et som sparar dessa värden till disk i JSON-format.
När sidan laddas om, hämtar webbsidan den senaste layouten från API:et och återställer de genererade rutorna.

## Krav
- React.js: Applikationen ska kunna rendera kvadrater dynamiskt på sidan.
- .NET/C# API: Hantering av state (spara och läsa in data från en JSON-fil).
- Inga CSS-ramverk krävs, men TailwindCSS kan användas om önskas.

## Wizardworks: Programmeringsuppgift
https://github.com/Wizardworks-AB/programmeringsuppgift?tab=readme-ov-file#wizardworks-programmeringsuppgift

## Getting Started

### Prerequisites
För att kunna köra den här applikationen behöver du följande verktyg installerade:

1. **.NET SDK 8.0**  
   Du kan ladda ner och installera .NET SDK 8.0 från [Microsofts officiella webbplats](https://dotnet.microsoft.com/download/dotnet/8.0).

2. **Node.js (för client-mappen om du har ett frontend)** (om tillämpligt)  
   Du kan ladda ner och installera Node.js från [Node.js officiella webbplats](https://nodejs.org/).

### Installation
Följ dessa steg för att klona och installera projektet lokalt:

1. **Klona repositoriet**
   ```bash
   git clone https://github.com/[ditt-användarnamn]/[namn-på-ditt-repo].git
   cd [namn-på-ditt-repo]
2. **Installera beroenden för .NET-projektet**
    Om du använder .NET Core:
    Kopiera kod
    ```bash
    dotnet restore
    ```
3. **Installera frontend-bibliotek (i 'client'-mappen) Om du har en frontend-mapp som kräver Node.js och NPM:**
    Kopiera kod
     ```bash
    cd client
    npm install
      ```
4. **Kör applikationen**
    För att köra backend-servern:
    Kopiera kod
     ```bash
      dotnet run --project MyApi
     ```
    Om du har en frontend-mapp och behöver köra den separat:
    Kopiera kod
    ```bash
      cd client
      npm start
    ```
