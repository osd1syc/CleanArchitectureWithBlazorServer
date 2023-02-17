global using MediatR;
global using Fluxor;
global using MediatR.Pipeline;
global using LazyCache;
global using Microsoft.Extensions.Localization;
global using AutoMapper;
global using AutoMapper.QueryableExtensions;
global using FluentValidation;
global using Microsoft.EntityFrameworkCore;
global using System.Data;
global using System.ComponentModel;
global using System.Linq.Dynamic.Core;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Primitives;
global using Microsoft.Extensions.Caching.Memory;
global using CleanArchitecture.Blazor.Domain;
global using CleanArchitecture.Blazor.Domain.Entities;
global using CleanArchitecture.Blazor.Domain.Events;
global using CleanArchitecture.Blazor.Application.Common.Mappings;
global using CleanArchitecture.Blazor.Application.Common.Models;
global using CleanArchitecture.Blazor.Application.Common.Extensions;
global using CleanArchitecture.Blazor.Application.Common.Interfaces;
global using CleanArchitecture.Blazor.Application.Common.Interfaces.Caching;
global using CleanArchitecture.Blazor.Domain.Entities.Audit;
global using CleanArchitecture.Blazor.Domain.Entities.Log;
global using CleanArchitecture.Blazor.Application.Common.Specification;
global using CleanArchitecture.Blazor.Application.Common.Exceptions;
global using AutoFilterer.Attributes;
global using AutoFilterer.Enums;
global using AutoFilterer.Extensions;
global using AutoFilterer.Types;
global using static CleanArchitecture.Blazor.Application.Common.Helper.ConstantStringLocalizer;