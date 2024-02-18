﻿global using AutoMoreira.Core.Domains;
global using AutoMoreira.Core.Domains.Identity;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading.Tasks;
global using System;
global using AutoMoreira.Core.Dto;
global using AutoMoreira.Core.Dto.Identity;
global using AutoMoreira.Persistence.Context;
global using AutoMoreira.Persistence.Interfaces.Repositories;
global using AutoMoreira.Persistence.Interfaces.Services;
global using AutoMapper;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using AutoMoreira.Core.Domains.Enum;
global using AutoMoreira.Persistence.Mapping;
global using AutoMoreira.Persistence.Repositories;
global using AutoMoreira.Persistence.Services;
global using HotChocolate.Types.Pagination;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;
global using HotChocolate.Types;
global using HotChocolate.Data;
global using HotChocolate;
global using AutoMoreira.Persistence.GraphQL;
global using Equipments.Data.EF.GraphQL.DomainsMap;
global using System.Linq.Expressions;
global using AutoMoreira.Persistence.Mapping.Seed;