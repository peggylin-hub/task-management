# Task Management MAUI Application

A cross-platform task management application built with .NET MAUI for desktop (Windows/macOS), mobile (Android/iOS), and web platforms.

## Project Structure

```
├── Platforms/              # Platform-specific code
│   ├── Android/            # Android-specific implementations
│   ├── iOS/               # iOS-specific implementations
│   ├── Windows/           # Windows-specific implementations
│   └── MacCatalyst/       # macOS-specific implementations
├── Views/                 # XAML pages and user controls
│   ├── Auth/              # Login/Registration pages
│   ├── Tasks/             # Task management pages
│   ├── Settings/          # User settings and preferences
│   └── Shared/            # Reusable controls and templates
├── ViewModels/            # ViewModel classes (MVVM pattern)
│   ├── Auth/              # Authentication ViewModels
│   ├── Tasks/             # Task management ViewModels
│   └── Base/              # Base ViewModels and common functionality
├── Models/                # Data models and entities
│   ├── DTOs/              # Data Transfer Objects for API communication
│   ├── Entities/          # Local database entities
│   └── Responses/         # API response models
├── Services/              # Business logic and data services
│   ├── Auth/              # Authentication services
│   ├── Tasks/             # Task management services
│   ├── Sync/              # Data synchronization services
│   ├── Storage/           # Local data storage services
│   └── Network/           # API communication services
├── Data/                  # Database context and repositories
│   ├── Context/           # SQLite database context
│   └── Repositories/      # Data access layer
├── Helpers/               # Utility classes and extensions
│   ├── Converters/        # XAML value converters
│   ├── Constants/         # Application constants
│   └── Extensions/        # Extension methods
├── Resources/             # Images, fonts, styles, and other assets
├── App.xaml              # Application-level resources and configuration
└── MauiProgram.cs        # Application startup and dependency injection
```

## Features to be Implemented

- User Authentication: Secure login/logout with token-based authentication
- Task Management: Create, edit, delete, and organize tasks
- Real-time Sync: Changes sync automatically across all platforms
- Offline Support: Work offline with automatic sync when connection is restored
- Cross-platform: Single codebase for desktop and mobile with web integration

## Technology Stack

- Framework: .NET MAUI (.NET 9)
- Language: C#
- UI Framework: XAML with MAUI Controls
- Architecture Pattern: MVVM (Model-View-ViewModel)
- Platforms: Android, iOS, Windows, macOS

## Key Dependencies

- `CommunityToolkit.Mvvm` - MVVM helpers and commands
- `CommunityToolkit.Maui` - Additional MAUI controls and extensions
- `Microsoft.Extensions.Http` - HTTP client factory with retry policies
- `sqlite-net-pcl` - SQLite database for local storage
- `Microsoft.EntityFrameworkCore.Sqlite` - EF Core for database operations
- `Polly` - Resilience and retry policies for network calls
- `Refit` - Type-safe REST API client
- `Microsoft.AspNetCore.SignalR.Client` - Real-time communication

## Getting Started

1. Ensure you have .NET 9 SDK installed
2. Install the required MAUI workloads:
   ```bash
   dotnet workload restore
   ```
3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```
4. Build the project:
   ```bash
   dotnet build
   ```

## Running the Application

- **Windows**: `dotnet run --framework net9.0-windows10.0.19041.0`
- **Android**: Use Visual Studio or VS Code with the MAUI extension
- **iOS**: Requires macOS with Xcode
- **macOS**: Requires macOS development environment

## Development Guidelines

- Follow MVVM pattern strictly - no code-behind logic in views
- Use dependency injection for service management
- Implement proper async/await patterns for asynchronous operations
- Use meaningful names for variables, methods, and classes
- Follow C# naming conventions

## Next Steps

The project is now set up with a clean structure. Ready for implementing:

1. Authentication system
2. Task management features  
3. Data synchronization
4. UI/UX implementation
5. Testing infrastructure
