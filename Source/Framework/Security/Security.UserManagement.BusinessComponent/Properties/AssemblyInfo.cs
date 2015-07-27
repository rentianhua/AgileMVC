using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;

[assembly: AssemblyTitle("HiiP.Framework.Security.UserManagement.BusinessComponent")]
[assembly: AssemblyDescription("HiiP Framework Security UserManagement BusinessComponent")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: AssemblyFileVersion("4.0.20724.0")]
// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c07fbf69-165d-47db-adb4-89c8f8b5b43b")]

[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetSubOffices(System.String,System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetAllUsersInOffice(System.String,System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetDefaultOfficeDetailForUser(System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetAllOfficesOfUser(System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetAllOfficesByType(System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetParentOffice(System.String,System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetSubOffices(System.Int32)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetDefaultOfficeIDForUser(System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetParentOffice(System.Int32)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]
[module: SuppressMessage("HiiP.Usages", "HP5002:UseInstanceBuilderToCreateObjectOnServerSide", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetDefaultOfficeNameForUser(System.String)", MessageId = "UseInstanceBuilderToCallMethodsWithAttributes")]


[module: SuppressMessage("HiiP.ExceptionHandling", "HP5001:ExceptionHandlingOnServerSideNotAllowed", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserMaintenanceServiceBC.#UpdateWFUser(HiiP.Framework.Security.UserManagement.BusinessEntity.UserInfoEntity,System.Boolean,System.String[],System.String[],System.String[],System.String[],System.String[])", MessageId = "ExceptionHandlingOnServerSideNotAllowed")]
[module: SuppressMessage("HiiP.ExceptionHandling", "HP5001:ExceptionHandlingOnServerSideNotAllowed", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserMaintenanceServiceBC.#CreateUserInfo(HiiP.Framework.Security.UserManagement.BusinessEntity.UserInfoEntity,System.Collections.Generic.List`1<HiiP.Framework.Security.UserManagement.BusinessEntity.OfficeEntity>,System.Collections.Generic.List`1<HiiP.Framework.Security.UserManagement.BusinessEntity.DataFilterEntity>,System.String[],System.Boolean,System.String[],System.String[],System.String[],System.String[],System.String[],System.Collections.Generic.List`1<HiiP.Framework.Security.UserManagement.BusinessEntity.ETRoleEntity>,HiiP.Framework.Security.UserManagement.BusinessEntity.OfficesHierarchyDataSet+OrganisationUserDataTable,HiiP.Framework.Security.UserManagement.BusinessEntity.OfficesHierarchyDataSet+OrganisationUserDataTable)", MessageId = "ExceptionHandlingOnServerSideNotAllowed")]
[module: SuppressMessage("HiiP.ExceptionHandling", "HP5001:ExceptionHandlingOnServerSideNotAllowed", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserMaintenanceServiceBC.#UpdateUserInfo(HiiP.Framework.Security.UserManagement.BusinessEntity.UserInfoEntity,System.Collections.Generic.List`1<HiiP.Framework.Security.UserManagement.BusinessEntity.OfficeEntity>,System.Collections.Generic.List`1<HiiP.Framework.Security.UserManagement.BusinessEntity.DataFilterEntity>,System.String[],System.Boolean,System.String[],System.String[],System.String[],System.String[],System.String[],System.String[],System.Boolean,System.Boolean,System.Collections.Generic.List`1<HiiP.Framework.Security.UserManagement.BusinessEntity.ETRoleEntity>,System.Collections.Generic.List`1<HiiP.Framework.Security.UserManagement.BusinessEntity.ETRoleEntity>,HiiP.Framework.Security.UserManagement.BusinessEntity.OfficesHierarchyDataSet+OrganisationUserDataTable,HiiP.Framework.Security.UserManagement.BusinessEntity.OfficesHierarchyDataSet+OrganisationUserDataTable)", MessageId = "ExceptionHandlingOnServerSideNotAllowed")]
[module: SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.Extension.#Descendants`1(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,System.Collections.Generic.IEnumerable`1<!!0>>)")]

[module: SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#GetAllUsersInOffice(System.String,System.String)", MessageId = "codeID")]

[module: SuppressMessage("HiiP.Logging", "HP5003:LoggingForServerSideMethodRequired", Scope = "member", Target = "HiiP.Framework.Security.UserManagement.BusinessComponent.UserCommonServiceBC.#IsActiveUser(System.String)", MessageId = "LoggingForServerSideMethodRequired")]