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
	/// <summary>Indstillinger</summary>
	[PublishedModel("indstillinger")]
	public partial class Indstillinger : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "indstillinger";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Indstillinger, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Indstillinger(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Antal dage før udlejet lejlighed forsvinder: Antal dage fra at lejlighed ikke længere er ledig til den forsvinder på sitet
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("antalDageForUdlejetLejlighedForsvinder")]
		public int AntalDageForUdlejetLejlighedForsvinder => this.Value<int>("antalDageForUdlejetLejlighedForsvinder");

		///<summary>
		/// Hjemmeside navnet: Denne bliver brugt til meta titlerne
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hjemmesideNavnet")]
		public string HjemmesideNavnet => this.Value<string>("hjemmesideNavnet");

		///<summary>
		/// Højre kolonne footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hojreKolonneFooter")]
		public IHtmlString HojreKolonneFooter => this.Value<IHtmlString>("hojreKolonneFooter");

		///<summary>
		/// Ikon: Dette ikon bliver brugt i tabben på browseren
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("ikon")]
		public IPublishedContent Ikon => this.Value<IPublishedContent>("ikon");

		///<summary>
		/// Logo: Dette bliver vist ved menupunkterne
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("logo")]
		public IPublishedContent Logo => this.Value<IPublishedContent>("logo");

		///<summary>
		/// Midt kolonne footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("midtKolonneFooter")]
		public IHtmlString MidtKolonneFooter => this.Value<IHtmlString>("midtKolonneFooter");

		///<summary>
		/// Om åbent hus: Dette er den beskrivende tekst, der forklarer hvad man skal gøre i forbindelse med åbenthus
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("omAbentHus")]
		public string OmAbentHus => this.Value<string>("omAbentHus");

		///<summary>
		/// Standard tal antenne gebyr: Det er dette tal der bliver vist, hvis antenne gebyr ikke er sat
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("standardTalAntenneTilslutning")]
		public int StandardTalAntenneTilslutning => this.Value<int>("standardTalAntenneTilslutning");

		///<summary>
		/// Standard tekst fremvisning: Det er den tekst der bliver vist, hvis fremvisnings datoen er overskredet, eller hvis den ikke er sat
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("standardTekstFremvisning")]
		public string StandardTekstFremvisning => this.Value<string>("standardTekstFremvisning");

		///<summary>
		/// Standard tekst ledig fra: Det er den tekst der bliver vist, hvis ledig fra datoen er overskredet, eller hvis den ikke er sat
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("standardTekstLedigFra")]
		public string StandardTekstLedigFra => this.Value<string>("standardTekstLedigFra");

		///<summary>
		/// Standard tekst: Hvis værdi/tekst ikke er udfyldt, så kommer dette til at stå
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("standardVaerdiHvisIkkeUdfyldt")]
		public string StandardVaerdiHvisIkkeUdfyldt => this.Value<string>("standardVaerdiHvisIkkeUdfyldt");

		///<summary>
		/// Venstre kolonne footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("venstreKolonneFooter")]
		public IHtmlString VenstreKolonneFooter => this.Value<IHtmlString>("venstreKolonneFooter");
	}
}