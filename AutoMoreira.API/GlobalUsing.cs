﻿global using AutoMoreira.Core.Dto;
global using AutoMoreira.Persistence.Interfaces.Services;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using System;
global using System.Threading.Tasks;
global using AutoMoreira.API.Extensions;
global using AutoMoreira.Core.Dto.Identity;
global using AutoMoreira.Persistence.Helpers;
global using Microsoft.AspNetCore.Hosting;
global using System.IO;
global using System.Linq;
global using System.Security.Claims;
global using AutoMoreira.API.Helpers;
global using System.Text.Json;
global using AutoMoreira.Core.Domains.Identity;
global using AutoMoreira.Persistence.Context;
global using AutoMoreira.Persistence.Interfaces.Repositories;
global using AutoMoreira.Persistence.Repositories;
global using AutoMoreira.Persistence.Services;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.FileProviders;
global using Microsoft.Extensions.Hosting;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.OpenApi.Models;
global using System.Collections.Generic;
global using System.Text;
global using System.Text.Json.Serialization;
global using AutoMoreira.Persistence.ServicesRegistry;