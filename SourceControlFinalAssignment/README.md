# Source Control Final Assignment
- Please use this README to navigate easily.
1) Create Login, Registration and Display a simple Dashboard page with detail of User after Successful Login or Register
   - **Controllers**: [AccountController](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Controllers/AccountController.cs), [ManageController](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Controllers/ManageController.cs)
   - **Models**: [AccountViewModels](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/AccountViewModels.cs), [ManageViewModels](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/ManageViewModels.cs),
   [IdentityModels](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/IdentityModels.cs)
   - Login and Registration is provided using ASP.NET Identity. Scaffolded with Individual User Authentication while creating the project.
   - I have removed extra features provided by default in ASP.NET Identity (e.g.: TwoFactorAuthentication, Social Logins, etc.)
   - Only the basic Login, Register, Change Password Features are kept intact.
   - After successful login, user is directed to the Homepage/Dashboard.
   - Screenshots:
   ![Dashboard](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/Screenshots/Dashboard.jpg?raw=true)
   - Respective Commits: 
     - [IdentityModels](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/IdentityModels.cs)
2) Mapped the project in Git with below operations:
   - **2.1 Commit and Push**: Below are the links of the respective links to demonstrate Commit and Push:
     - [Initial Project Setup](https://github.com/mformihir/Assignments-Gateway/commit/0f0cac4bb6eb66724c32b49dfc1a9ebc40f1a836)
     - [Removed unnecessary authentication from ViewModels](https://github.com/mformihir/Assignments-Gateway/commit/82e3f343b15691e083d007b025241f76f9ec5013)
   - **2.2 Fetch and Pull**: Performed Fetch and Pull while working on the project.
   - **2.3 Undo**: Performed Undoing(Resetting) commits while working on the project (Resetted the HEAD on the local repository to a previous commit and pushed it to github).
   - **2.4 Merge**: Created a branch (named CustomJquery) while adding a feature and Merged it to the Main branch. The link to the respective commit is as below:
     - [Merge pull request #1 from mformihir/CustomJquery](https://github.com/mformihir/Assignments-Gateway/commit/86992bf0e97f55ea4189824deaab74208f8f4188)
   - **2.5 Resolved Conflicts**: Performed resolving conflicts on a local test repository as I did not run into conflicts while creating this project.
3) Data Annotation and Validations:
   - **3.1 Server-side validations with validator attributes**: 
     - [3.1.1 Range](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/Product.cs#L24)
     - [3.1.2 Regular Expression](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/Product.cs#L18)
     - [3.1.3 Required](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/Product.cs#L14)
     - [3.1.4 String Length](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/Product.cs#L28)
     - [3.1.5 File Extension](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/Product.cs#L38):
       - Created a custom validator for file extension: [FileExtensionsAttribute.cs](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/FileExtensionsAttribute.cs)
     - [3.1.6 Custom Validation](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/Product.cs#L44):
       - [ProductRegionAttribute.cs](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/ProductRegionAttribute.cs)
     - [3.1.7 Phone](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Models/Product.cs#L41)
     - **Usage/Demonstration**: [Create.cshtml](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/SourceControlFinalAssignment/Views/Products/Create.cshtml)
     - **Respective Commits**:
       - [Data Annotation and Validations](https://github.com/mformihir/Assignments-Gateway/commit/bc927f0e853e738cb4537108317b25534238c9e9#diff-b0a4b46b8c2733fc2a9d7a442af106ef5e199eb84a57cc68f0bae2ca25b35686)
   - **3.2 Client-side validations using jQuery**:
     - **3.2.1 Configuration in MVC Project:** Performed. Already configured while creating the project.
     - **3.2.2 Default validations:** Performed.
     - **3.2.3 Custom validations:** Performed. Link to respective View: [Create.cshtml](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Views/Products/Create.cshtml#L104)
     - **3.2.4 Methods:** Created a jQuery function which validates the form along with the custom validation. Link to respective View: [Create.cshtml](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Views/Products/Create.cshtml#L121)
   - **Validation with Messages & Summary**:
     - **3.2.5 ValidationSummary:** Performed. Link to respective View: [Create.cshtml](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Views/Products/Create.cshtml#L17)
     - **3.2.6 ValidationMessageFor:** Performed. Link to respective View: [Create.cshtml](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Views/Products/Create.cshtml#L30)
     - **3.2.7 ValidationMessage:** Performed. Link to respective View: [Create.cshtml](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Views/Products/Create.cshtml#L22)
     - **3.2.8 Client-side validations:** Performed. Link to respective View: [Create.cshtml](https://github.com/mformihir/Assignments-Gateway/blob/e147dc19926bf536068fe518e11e4bd5204466a9/SourceControlFinalAssignment/SourceControlFinalAssignment/Views/Products/Create.cshtml)
   - Screenshots: 
   ![ProductForm](https://github.com/mformihir/Assignments-Gateway/blob/main/SourceControlFinalAssignment/Screenshots/ProductForm.jpg?raw=true)
  1) Manage NuGet Packages of NewtonsoftJson:
     - NewtonsoftJson was already installed with the project at the time of creation.
     - Updated the Nuget Package of NewtonsoftJson from 12.0.2 -> 12.0.3.
     - **Respective Commits:**
       - [Manage NuGet Packages of NewtonsoftJson](https://github.com/mformihir/Assignments-Gateway/commit/d5430105d79f71b9a7df85089118c408f6360909)
  2) Exception Handling & Logging:
     - Log4net (Logging in text file + logging in SQL database):
       - Added the Log4net package from NuGet Package manager. Configured it for logfile and for the database. Respective Commit: [Exception Handling & Logging](https://github.com/mformihir/Assignments-Gateway/commit/db106eab0623a19bb38094ecd681aa986e5b6fb1)
       - The log statements are demonstrated in [ProductsController.cs](https://github.com/mformihir/Assignments-Gateway/blob/db106eab0623a19bb38094ecd681aa986e5b6fb1/SourceControlFinalAssignment/SourceControlFinalAssignment/Controllers/ProductsController.cs#L19)