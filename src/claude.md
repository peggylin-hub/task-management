\# MAUI Task Management Application - Claude Code Configuration



\## Project Overview

This is a cross-platform task management application built with .NET MAUI that allows users to manage tasks across desktop (Windows/macOS), mobile (Android/iOS), and web platforms. The application features user authentication, real-time synchronization, and offline capability with automatic sync when connectivity is restored.



\## Application Features

\- \*\*User Authentication\*\*: Secure login/logout with token-based authentication

\- \*\*Task Management\*\*: Create, edit, delete, and organize tasks

\- \*\*Real-time Sync\*\*: Changes sync automatically across all platforms (desktop, web, mobile)

\- \*\*Offline Support\*\*: Work offline with automatic sync when connection is restored

\- \*\*Cross-platform\*\*: Single codebase for desktop and mobile with web integration



\## Technology Stack

\- \*\*Framework\*\*: .NET MAUI (.NET 8+)

\- \*\*Language\*\*: C#

\- \*\*UI Framework\*\*: XAML with MAUI Controls

\- \*\*Architecture Pattern\*\*: MVVM (Model-View-ViewModel)

\- \*\*Platforms\*\*: Android, iOS, Windows, macOS



\## Project Structure

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



\## Development Guidelines



\### Code Style \& Conventions

\- Follow C# naming conventions (PascalCase for public members, camelCase for private fields)

\- Use meaningful names for variables, methods, and classes

\- Implement proper async/await patterns for asynchronous operations

\- Use dependency injection for service management

\- Follow MVVM pattern strictly - no code-behind logic in views



\### XAML Guidelines

\- Use data binding instead of direct UI manipulation

\- Implement proper resource management with StaticResource and DynamicResource

\- Use consistent spacing and indentation (4 spaces)

\- Group related properties together in XAML elements

\- Use meaningful x:Name values when element access is needed



\### Performance Considerations

\- Implement virtualization for large data sets (CollectionView)

\- Use image optimization and caching

\- Minimize layout complexity and nesting

\- Implement proper memory management and dispose patterns

\- Use compiled bindings when possible for better performance



\## Key Dependencies \& NuGet Packages

\- `Microsoft.Extensions.Logging` - Logging framework

\- `CommunityToolkit.Mvvm` - MVVM helpers and commands

\- `CommunityToolkit.Maui` - Additional MAUI controls and extensions

\- `System.Text.Json` - JSON serialization for API communication

\- `Microsoft.Extensions.Http` - HTTP client factory with retry policies

\- `sqlite-net-pcl` - SQLite database for local storage

\- `Microsoft.EntityFrameworkCore.Sqlite` - EF Core for database operations

\- `Polly` - Resilience and retry policies for network calls

\- `Microsoft.Authentication.WebAssembly.Msal` - Authentication library

\- `Refit` - Type-safe REST API client

\- `SignalR.Client` - Real-time communication for sync updates

\- `Connectivity.Plugin` - Network connectivity detection

\- `SecureStorage.Plugin` - Secure token storage



\## Common Tasks \& Patterns



\### Authentication Flow

1\. Implement login/logout ViewModels with secure token storage

2\. Use dependency injection for authentication services

3\. Implement automatic token refresh mechanism

4\. Handle authentication state across app lifecycle

5\. Secure API calls with bearer token authentication



\### Task Management Operations

1\. Create task CRUD operations with local and remote persistence

2\. Implement offline-first approach with conflict resolution

3\. Use repository pattern for data access abstraction

4\. Implement real-time updates via SignalR connections

5\. Handle optimistic UI updates with rollback on failure



\### Data Synchronization

1\. Implement background sync service for automatic updates

2\. Use last-modified timestamps for conflict resolution

3\. Queue local changes when offline for later sync

4\. Handle partial sync failures gracefully

5\. Notify users of sync status and conflicts



\### Cross-Platform Considerations

\- Use `SecureStorage` for token persistence across platforms

\- Implement platform-specific notification handling

\- Handle network connectivity changes appropriately

\- Manage app lifecycle events for sync operations



\### Data Binding for Task Management

\- Use `ObservableCollection` for task lists with real-time updates

\- Implement `INotifyPropertyChanged` for task properties

\- Use data templates for different task types and states

\- Bind to sync status for user feedback



\## Application Architecture Patterns



\### Authentication \& Security

\- Implement secure token storage using platform-specific secure storage

\- Use JWT tokens with automatic refresh mechanisms

\- Implement proper logout with token cleanup

\- Handle authentication failures and expired tokens gracefully



\### Data Layer Architecture

\- \*\*Repository Pattern\*\*: Abstract data access for both local and remote sources

\- \*\*Unit of Work\*\*: Manage transactions across multiple repositories

\- \*\*Offline-First\*\*: Local SQLite database as primary data source

\- \*\*Conflict Resolution\*\*: Last-writer-wins with user notification for conflicts



\### Synchronization Strategy

\- \*\*Background Sync\*\*: Automatic sync when app is backgrounded/foregrounded

\- \*\*Real-time Updates\*\*: SignalR for live updates from web application

\- \*\*Optimistic Updates\*\*: Update UI immediately, rollback on server failure

\- \*\*Retry Logic\*\*: Exponential backoff for failed sync operations



\### Error Handling \& User Experience

\- Implement global exception handling with user-friendly messages

\- Show sync status indicators in UI (syncing, offline, error states)

\- Provide manual sync option for user control

\- Handle network connectivity changes gracefully



\## Testing Strategy

\- \*\*Unit Tests\*\*: ViewModels, Services, and Repository classes

\- \*\*Integration Tests\*\*: API communication and database operations

\- \*\*Sync Testing\*\*: Multi-device synchronization scenarios

\- \*\*Authentication Tests\*\*: Login/logout flows and token management

\- \*\*Offline Tests\*\*: Functionality without network connectivity

\- \*\*UI Tests\*\*: Cross-platform user interface behavior

\- \*\*Performance Tests\*\*: Sync performance with large datasets



\## Platform-Specific Notes



\### Android

\- Target API level 33+ (Android 13)

\- Configure proper permissions in `Platforms/Android/AndroidManifest.xml`

\- Handle Android back button navigation

\- Implement proper activity lifecycle management



\### iOS

\- Target iOS 14.0+

\- Configure Info.plist for required permissions

\- Handle iOS-specific navigation patterns

\- Implement proper memory management for iOS



\### Windows

\- Target Windows 10 version 1809+

\- Configure proper app manifest

\- Handle Windows-specific input methods

\- Implement proper window management



\## Common Issues \& Solutions



\### Authentication Issues

\- Store tokens securely using `SecureStorage` API

\- Implement token refresh before expiration

\- Handle login state persistence across app restarts

\- Clear authentication state properly on logout



\### Synchronization Challenges

\- Implement proper conflict resolution for concurrent edits

\- Handle partial sync failures without data corruption

\- Use optimistic locking to prevent data loss

\- Implement retry mechanisms with exponential backoff



\### Offline Functionality

\- Cache user data locally for offline access

\- Queue operations when offline for later sync

\- Provide clear offline indicators in UI

\- Handle data conflicts when coming back online



\### Cross-Platform Sync Issues

\- Ensure consistent data format across platforms

\- Handle timezone differences in task due dates

\- Implement proper serialization for complex objects

\- Test sync behavior on all target platforms



\### Performance \& User Experience

\- Implement lazy loading for large task lists

\- Use virtualization for performance with many tasks

\- Provide loading indicators during sync operations

\- Cache frequently accessed data locally



\### Platform-Specific Considerations

\- Handle Android back button for proper navigation

\- Implement iOS-specific swipe gestures for task actions

\- Configure proper Windows desktop experience

\- Handle macOS-specific UI patterns and interactions



\## Resources \& Documentation

\- \[Microsoft MAUI Documentation](https://docs.microsoft.com/en-us/dotnet/maui/)

\- \[MAUI Community Toolkit](https://docs.microsoft.com/en-us/dotnet/communitytoolkit/maui/)

\- \[Platform-Specific Development](https://docs.microsoft.com/en-us/dotnet/maui/platform-integration/)



\## Notes for Claude Code

\- \*\*Authentication First\*\*: Always consider user authentication state in suggestions

\- \*\*Sync-Aware Development\*\*: Recommend patterns that work with real-time synchronization

\- \*\*Offline-First Design\*\*: Suggest solutions that work offline with eventual consistency

\- \*\*Cross-Platform Sync\*\*: Consider how changes will sync between desktop, web, and mobile

\- \*\*Task Management Focus\*\*: Prioritize task CRUD operations and management features

\- \*\*Security Conscious\*\*: Always recommend secure storage and transmission of user data

\- \*\*Performance with Sync\*\*: Consider network efficiency and local storage optimization

\- \*\*User Experience\*\*: Suggest UI patterns that clearly communicate sync status and conflicts

\- \*\*Error Resilience\*\*: Recommend robust error handling for network and sync failures

\- \*\*Multi-Device Experience\*\*: Consider how the app works across different device types and screen sizes

