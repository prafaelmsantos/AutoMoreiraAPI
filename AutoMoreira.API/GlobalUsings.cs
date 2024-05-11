﻿global using System;
global using System.Collections.Generic;
global using System.Text;
global using System.Text.Json.Serialization;
global using System.Threading.Tasks;
global using AutoMoreira.Core.Domains.Enum;
global using AutoMoreira.Core.Dto;
global using AutoMoreira.Core.Dto.Identity;
global using AutoMoreira.Persistence.Context;
global using AutoMoreira.Persistence.Interfaces.Services;
global using AutoMoreira.Persistence.ServicesRegistry;
global using HotChocolate.AspNetCore;
global using HotChocolate.AspNetCore.Playground;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
