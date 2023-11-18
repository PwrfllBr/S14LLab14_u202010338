Nota: Para trabajar con Entity Framework en capas SIN QUE SE ROMPA TODO:
1. Instalar EntityFramework en el proyecto de la capa de presentación desde el NuGet Packet Manager
2. Copia el <ConnectionString> del archivo App.config del proyecto en el que esté el Entity Framework Model al App.Config de tu capa de presentación
3. Referenciar las capas de abajo en las capas de arriba
