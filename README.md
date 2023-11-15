Nota: Para trabajar con Entity Framework en capas SIN QUE SE ROMPA TODO AL CHOTO:
1. Instala EntityFramework en el proyecto de la capa de presentación desde el NuGet Packet Manager
2. Copia el <ConnectionString> del archivo App.config del proyecto en el que tengas el Entity Framework Model al App.Config de tu capa de presentación
3. No olvides referenciar las capas de abajo en las capas de arriba
