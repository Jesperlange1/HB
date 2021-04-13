//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Lejemål</summary>
	[PublishedModel("lejemal")]
	public partial class Lejemal : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "lejemal";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Lejemal, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Lejemal(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Aconto varme
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("aconto")]
		public int Aconto => this.Value<int>("aconto");

		///<summary>
		/// Adresse
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("adresse")]
		public string Adresse => this.Value<string>("adresse");

		///<summary>
		/// Altan/Terasse
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("altanTerasse")]
		public string AltanTerasse => this.Value<string>("altanTerasse");

		///<summary>
		/// Antal værelser
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("antalVaerelser")]
		public int AntalVaerelser => this.Value<int>("antalVaerelser");

		///<summary>
		/// Antenne gebyr: En standard antennegebyrs pris bliver vist, hvis denne ikke bliver udfyldt, tjek indstillinger
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("antenneTilslutning")]
		public int AntenneTilslutning => this.Value<int>("antenneTilslutning");

		///<summary>
		/// Bad: Dette er automatisk eget, hvis den ikke er udfyldt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bad")]
		public string Bad => this.Value<string>("bad");

		///<summary>
		/// Beskrivelse
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("beskrivelse")]
		public IHtmlString Beskrivelse => this.Value<IHtmlString>("beskrivelse");

		///<summary>
		/// Billeder: Billeder af selve lejligheden. VIGTIGT max 1mb, helst mindre
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("billeder")]
		public IEnumerable<IPublishedContent> Billeder => this.Value<IEnumerable<IPublishedContent>>("billeder");

		///<summary>
		/// By
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("by")]
		public string By => this.Value<string>("by");

		///<summary>
		/// Depositum: Det totale depositum med forudbetalt husleje og depositum
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("depositum")]
		public int Depositum => this.Value<int>("depositum");

		///<summary>
		/// El: Dette er ikke inkluderet i huslejen hvis intet valgt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("el")]
		public string El => this.Value<string>("el");

		///<summary>
		/// Fælles vaskeri
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("faellesVaskeri")]
		public string FaellesVaskeri => this.Value<string>("faellesVaskeri");

		///<summary>
		/// Fælles vaskeri inkluderet i husleje: Denne bliver ikke vist, hvis der er svaret nej til fælles vaskeri. Og hvis den ikke er udfyldt, så vil den vise inkluderet i husleje
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("faellesVaskeriPris")]
		public string FaellesVaskeriPris => this.Value<string>("faellesVaskeriPris");

		///<summary>
		/// Fremvisnings dato: Hvis denne ikke er udfyldt eller datoen er overskredet, så vil standardteksten blive brugt, se indstillinger
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("fremvisningsDato")]
		public DateTime FremvisningsDato => this.Value<DateTime>("fremvisningsDato");

		///<summary>
		/// Fremvisnings slut tid: Vælg slut tidspunktet
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("fremvisningsSlutTid")]
		public string FremvisningsSlutTid => this.Value<string>("fremvisningsSlutTid");

		///<summary>
		/// Fremvisnings start tid: Vælg start tidspunktet
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("fremvisningsStartTid")]
		public string FremvisningsStartTid => this.Value<string>("fremvisningsStartTid");

		///<summary>
		/// Gulve
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("gulve")]
		public string Gulve => this.Value<string>("gulve");

		///<summary>
		/// Husdyr tilladt: Dette er automatisk nej, hvis den ikke er udfyldt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("husdyr")]
		public string Husdyr => this.Value<string>("husdyr");

		///<summary>
		/// Husleje inkl. vand
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("husleje")]
		public int Husleje => this.Value<int>("husleje");

		///<summary>
		/// Kort Beskrivelse: En kort beskrivelse, blive brugt på siden Ledige lejemål, og som meta tekst, hvis den ikke er udfyldt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("kortBeskrivelse")]
		public string KortBeskrivelse => this.Value<string>("kortBeskrivelse");

		///<summary>
		/// Kvadratmeter / m2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("kvadratmeterM2")]
		public int KvadratmeterM2 => this.Value<int>("kvadratmeterM2");

		///<summary>
		/// Ledig: Denne skal være tjekket af for at vise lejligheden er ledig
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("ledig")]
		public bool Ledig => this.Value<bool>("ledig");

		///<summary>
		/// Ledig fra: Hvis denne ikke er udfyldt eller datoen er overskredet, så vil standardteksten blive brugt, se indstillinger
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("ledigFra")]
		public DateTime LedigFra => this.Value<DateTime>("ledigFra");

		///<summary>
		/// Lejemålets stand
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("lejemaletsStand")]
		public string LejemaletsStand => this.Value<string>("lejemaletsStand");

		///<summary>
		/// Lejemålsnr
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("lejemalsnr")]
		public int Lejemalsnr => this.Value<int>("lejemalsnr");

		///<summary>
		/// Post nr.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("postNr")]
		public string PostNr => this.Value<string>("postNr");

		///<summary>
		/// Toilet: Dette er automatisk eget, hvis den ikke er udfyldt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("toilet")]
		public string Toilet => this.Value<string>("toilet");

		///<summary>
		/// Vand: Dette er inkluderet i huslejen hvis intet valgt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("vand")]
		public string Vand => this.Value<string>("vand");
	}
}