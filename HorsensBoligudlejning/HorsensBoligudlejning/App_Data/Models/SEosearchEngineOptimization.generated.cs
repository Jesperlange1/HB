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
	// Mixin Content Type with alias "sEOSearchEngineOptimization"
	/// <summary>SEO - search engine optimization</summary>
	public partial interface ISEosearchEngineOptimization : IPublishedElement
	{
		/// <summary>Indexer ikke</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		bool IndexerIkke { get; }

		/// <summary>Meta beskrivelse</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string MetaBeskrivelse { get; }

		/// <summary>Meta titel</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string MetaTitel { get; }

		/// <summary>Skjul fra menu</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		bool SkjulFraMenu { get; }
	}

	/// <summary>SEO - search engine optimization</summary>
	[PublishedModel("sEOSearchEngineOptimization")]
	public partial class SEosearchEngineOptimization : PublishedElementModel, ISEosearchEngineOptimization
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "sEOSearchEngineOptimization";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SEosearchEngineOptimization, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SEosearchEngineOptimization(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Indexer ikke: Hvis denne er tjekket af, så bliver siden ikke indexeret af søgemaskiner (man vil ikke kunne søge efter siden på f.eks. google)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("indexerIkke")]
		public bool IndexerIkke => GetIndexerIkke(this);

		/// <summary>Static getter for Indexer ikke</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static bool GetIndexerIkke(ISEosearchEngineOptimization that) => that.Value<bool>("indexerIkke");

		///<summary>
		/// Meta beskrivelse: Dette er teksten som bliver vist lige under titlen på søgemaskiner
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaBeskrivelse")]
		public string MetaBeskrivelse => GetMetaBeskrivelse(this);

		/// <summary>Static getter for Meta beskrivelse</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetMetaBeskrivelse(ISEosearchEngineOptimization that) => that.Value<string>("metaBeskrivelse");

		///<summary>
		/// Meta titel: Denne bliver vist i toppen af søgeresultaterne på google. Hvis den ikke er udfyldt, så er det sidens titel og hjemmesidens navn
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaTitel")]
		public string MetaTitel => GetMetaTitel(this);

		/// <summary>Static getter for Meta titel</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetMetaTitel(ISEosearchEngineOptimization that) => that.Value<string>("metaTitel");

		///<summary>
		/// Skjul fra menu: Hvis denne er tjekket af, så vil siden ikke blive vist i menuen
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("skjulFraMenu")]
		public bool SkjulFraMenu => GetSkjulFraMenu(this);

		/// <summary>Static getter for Skjul fra menu</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static bool GetSkjulFraMenu(ISEosearchEngineOptimization that) => that.Value<bool>("skjulFraMenu");
	}
}