using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ServiceApp.Client;
using ServiceApp.Client.Services;
using ServiceApp.Client.Utility;
using MudBlazor.Services;
using ServiceApp.Shared.Model;
using ServiceApp.Shared.Model.Services.Accounting;
using ServiceApp.Shared.Model.Services.Accounting.SubServices;
using ServiceApp.Shared.Model.Services.OtherServices.SubServices;
using ServiceApp.Shared.Model.Services.OtherServices;
using ServiceApp.Shared.Model.Services.PSA;
using ServiceApp.Shared.Model.Services.PSA.SubServices;
using ServiceApp.Shared.Model.Services.DFA;
using ServiceApp.Shared.Model.Services.DFA.SubServices;
using ServiceApp.Shared.Model.Services.Notary;
using ServiceApp.Shared.Model.Services.LTO;
using ServiceApp.Shared.Model.Services.LTO.SubService;
using ServiceApp.Shared.Model.Services.Airline;
using ServiceApp.Shared.Model.Services.Airline.SubServices;
using ServiceApp.Shared.Model.Services.VISAProcessing.SubServices;
using ServiceApp.Shared.Model.Services.VISAProcessing;
using ServiceApp.Shared.Model.Services.Financial;
using ServiceApp.Shared.Model.Services.Financial.SubServices;
using ServiceApp.Shared.Model.Services.ATMPortable;
using ServiceApp.Shared.Model.Services.ATMPortable.SubServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, UserAuthenticationStateprovider>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<IPrintService, PrintService>();
builder.Services.AddSingleton<ClientInfo>();
builder.Services.AddSingleton<Accounting>();
builder.Services.AddSingleton<FilingOfTaxes>();
builder.Services.AddSingleton<BIRRegistration>();
builder.Services.AddSingleton<ITRPreparation>();
builder.Services.AddSingleton<DTIRegistration>();
builder.Services.AddSingleton<SECRegistration>();
builder.Services.AddSingleton<BusinessPermit>();
builder.Services.AddSingleton<PagIbigRegistration>();
builder.Services.AddSingleton<SSSRegistration>();
builder.Services.AddSingleton<PhilhealthRegistration>();
builder.Services.AddSingleton<Bookkeeping>();
builder.Services.AddSingleton<OtherServices>();
builder.Services.AddSingleton<TransferofTitle>();
builder.Services.AddSingleton<PCABAssistance>();
builder.Services.AddSingleton<NBIAssistance>();
builder.Services.AddSingleton<WeddingManagement>();
builder.Services.AddSingleton<PSA>();
builder.Services.AddSingleton<Cenomar>();
builder.Services.AddSingleton<BirthCertificate>();
builder.Services.AddSingleton<MarriageCertificate>();
builder.Services.AddSingleton<DeathCertificate>();
builder.Services.AddSingleton<DFA>();
builder.Services.AddSingleton<PassportAssistance>();
builder.Services.AddSingleton<LossPassport>();
builder.Services.AddSingleton<Notary>();
builder.Services.AddSingleton<LTO>();
builder.Services.AddSingleton<Registration>();
builder.Services.AddSingleton<VISAProcessing>();
builder.Services.AddSingleton<Airline>();
builder.Services.AddSingleton<Domestic>();
builder.Services.AddSingleton<International>();
builder.Services.AddSingleton<USA>();
builder.Services.AddSingleton<CanadaETA>();
builder.Services.AddSingleton<CanadaRegular>();
builder.Services.AddSingleton<NewZealand>();
builder.Services.AddSingleton<China>();
builder.Services.AddSingleton<Japan>();
builder.Services.AddSingleton<Australia>();
builder.Services.AddSingleton<EuropeanCountries>();
builder.Services.AddSingleton<SouthKorea>();
builder.Services.AddSingleton<Financial>();
builder.Services.AddSingleton<GCash>();
builder.Services.AddSingleton<ATMPortable>();
builder.Services.AddSingleton<BankBalanceInquiry>();
builder.Services.AddSingleton<Withdrawal>();
builder.Services.AddSingleton<TransactionInfoContainer>();

builder.Services.AddMudServices();
await builder.Build().RunAsync();
