﻿SELECT
	SERVERPROPERTY('BuildClrVersion') AS [BuildClrVersion],
	SERVERPROPERTY('Collation') AS [Collation],
	SERVERPROPERTY('CollationID') AS [CollationID],
	SERVERPROPERTY('ComparisonStyle') AS [ComparisonStyle],
	SERVERPROPERTY('ComputerNamePhysicalNetBIOS') AS [ComputerNamePhysicalNetBIOS],
	SERVERPROPERTY('Edition') AS [Edition],
	SERVERPROPERTY('EditionID') AS [EditionID],
	SERVERPROPERTY('EngineEdition') AS [EngineEdition],
	SERVERPROPERTY('FilestreamConfiguredLevel') AS [FilestreamConfiguredLevel],
	SERVERPROPERTY('FilestreamEffectiveLevel') AS [FilestreamEffectiveLevel],
	SERVERPROPERTY('FilestreamShareName') AS [FilestreamShareName],
	SERVERPROPERTY('HadrManagerStatus') AS [HadrManagerStatus],
	SERVERPROPERTY('InstanceName') AS [InstanceName],
	SERVERPROPERTY('IsClustered') AS [IsClustered],
	SERVERPROPERTY('IsFullTextInstalled') AS [IsFullTextInstalled],
	SERVERPROPERTY('IsHadrEnabled') AS [IsHadrEnabled],
	SERVERPROPERTY('IsIntegratedSecurityOnly') AS [IsIntegratedSecurityOnly],
	SERVERPROPERTY('IsLocalDB') AS [IsLocalDB],
	SERVERPROPERTY('IsSingleUser') AS [IsSingleUser],
	SERVERPROPERTY('IsXTPSupported') AS [IsXTPSupported],
	SERVERPROPERTY('LCID') AS [LCID],
	SERVERPROPERTY('LicenseType') AS [LicenseType],
	SERVERPROPERTY('MachineName') AS [MachineName],
	SERVERPROPERTY('NumLicenses') AS [NumLicenses],
	SERVERPROPERTY('ProcessID') AS [ProcessID],
	SERVERPROPERTY('ProductLevel') AS [ProductLevel],
	SERVERPROPERTY('ProductVersion') AS [ProductVersion],
	SERVERPROPERTY('ResourceLastUpdateDateTime') AS [ResourceLastUpdateDateTime],
	SERVERPROPERTY('ResourceVersion') AS [ResourceVersion],
	SERVERPROPERTY('ServerName') AS [ServerName],
	SERVERPROPERTY('SqlCharSet') AS [SqlCharSet],
	SERVERPROPERTY('SqlCharSetName') AS [SqlCharSetName],
	SERVERPROPERTY('SqlSortOrder') AS [SqlSortOrder],
	SERVERPROPERTY('SqlSortOrderName') AS [SqlSortOrderName]
	RETURN