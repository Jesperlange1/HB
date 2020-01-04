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
	/// <summary>Standard side</summary>
	[PublishedModel("standardSide")]
	public partial class StandardSide : PublishedContentModel, IMenuIcon, ISEosearchEngineOptimization
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "standardSide";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<StandardSide, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public StandardSide(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Hoved billede: Billedet øverst på siden. VIGTIGT max 1mb, helst mindre
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hovedBillede")]
		public IPublishedContent HovedBillede => this.Value<IPublishedContent>("hovedBillede");

		///<summary>
		/// Overskrift
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("overskrift")]
		public string Overskrift => this.Value<string>("overskrift");

		///<summary>
		/// Side indhold: Her udfyldes sidens indhold
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sideIndhold")]
		public IHtmlString SideIndhold => this.Value<IHtmlString>("sideIndhold");

		///<summary>
		/// Menu ikon: Vælg et memu ikon, som vil blive vist i menuen. Søg efter ikon her: https://fontawesome.com/icons?d=gallery&m=free
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("menuIkon")]
		public object MenuIkon => MenuIcon.GetMenuIkon(this);

		///<summary>
		/// Indexer ikke: Hvis denne er tjekket af, så bliver siden ikke indexeret af søgemaskiner (man vil ikke kunne søge efter siden på f.eks. google)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("indexerIkke")]
		public bool IndexerIkke => SEosearchEngineOptimization.GetIndexerIkke(this);

		///<summary>
		/// Meta beskrivelse: Dette er teksten som bliver vist lige under titlen på søgemaskiner
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaBeskrivelse")]
		public string MetaBeskrivelse => SEosearchEngineOptimization.GetMetaBeskrivelse(this);

		///<summary>
		/// Meta titel: Denne bliver vist i toppen af søgeresultaterne på google. Hvis den ikke er udfyldt, så er det sidens titel og hjemmesidens navn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaTitel")]
		public string MetaTitel => SEosearchEngineOptimization.GetMetaTitel(this);

		///<summary>
		/// Skjul fra menu: Hvis denne er tjekket af, så vil siden ikke blive vist i menuen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("skjulFraMenu")]
		public bool SkjulFraMenu => SEosearchEngineOptimization.GetSkjulFraMenu(this);
	}
}
