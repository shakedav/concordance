﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace concordanceapConcordationDataSetTableAdaptersp
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Concordation")]
	public partial class DBConDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DBConDataContext() : 
				base(global::concordanceapConcordationDataSetTableAdaptersp.Properties.Settings.Default.ConcordationConnectionString3, mappingSource)
		{
			OnCreated();
		}
		
		public DBConDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBConDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBConDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBConDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.addAttributes")]
		public int addAttributes([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> docID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string attValue, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> attType)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), docID, attValue, attType);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetSearchWord")]
		public ISingleResult<GetSearchWordResult> GetSearchWord([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((ISingleResult<GetSearchWordResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertWord")]
		public int InsertWord([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Word", DbType="VarChar(50)")] string word, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Line", DbType="Int")] System.Nullable<int> line, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WordNum", DbType="Int")] System.Nullable<int> wordNum, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DocID", DbType="Int")] System.Nullable<int> docID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word, line, wordNum, docID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ContextWords")]
		public ISingleResult<ContextWordsResult> ContextWords([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((ISingleResult<ContextWordsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetTaggedWords")]
		public ISingleResult<GetTaggedWordsResult> GetTaggedWords()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetTaggedWordsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddTag")]
		public int AddTag([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TagName", DbType="VarChar(50)")] string tagName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tagName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetTotalAppearances")]
		public int GetTotalAppearances([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetContainingDocs")]
		public int GetContainingDocs([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetContainingTags")]
		public int GetContainingTags([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetDocsOfWord")]
		public ISingleResult<GetDocsOfWordResult> GetDocsOfWord([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((ISingleResult<GetDocsOfWordResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetTagsofWord")]
		public ISingleResult<GetTagsofWordResult> GetTagsofWord([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((ISingleResult<GetTagsofWordResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.TagWord")]
		public int TagWord([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Word", DbType="VarChar(50)")] string word, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TagName", DbType="VarChar(50)")] string tagName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word, tagName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddRelation")]
		public int AddRelation([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Relation", DbType="VarChar(50)")] string relation)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), relation);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetContainingRelations")]
		public int GetContainingRelations([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getRelationsOfWord")]
		public ISingleResult<getRelationsOfWordResult> getRelationsOfWord([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((ISingleResult<getRelationsOfWordResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetWordID")]
		public int GetWordID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddExpression")]
		public int AddExpression([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> wordid, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Expression", DbType="VarChar(50)")] string expression, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> wordNum)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), wordid, expression, wordNum);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetExpressions")]
		public ISingleResult<GetExpressionsResult> GetExpressions()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetExpressionsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetContainingExpressions")]
		public int GetContainingExpressions([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertWord2")]
		public int InsertWord2([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Word", DbType="VarChar(50)")] string word, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Line", DbType="Int")] System.Nullable<int> line, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="WordNum", DbType="Int")] System.Nullable<int> wordNum, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DocID", DbType="Int")] System.Nullable<int> docID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word, line, wordNum, docID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetExpressionsOfWord")]
		public ISingleResult<GetExpressionsOfWordResult> GetExpressionsOfWord([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((ISingleResult<GetExpressionsOfWordResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetDocType")]
		public int GetDocType([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string typeName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), typeName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetDocAttrs")]
		public ISingleResult<GetDocAttrsResult> GetDocAttrs([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> doctype)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), doctype);
			return ((ISingleResult<GetDocAttrsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetTypeAtts")]
		public ISingleResult<GetTypeAttsResult> GetTypeAtts([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> docTypeID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), docTypeID);
			return ((ISingleResult<GetTypeAttsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.getDocID")]
		public int getDocID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string fileName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fileName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAttTypeID")]
		public int GetAttTypeID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string attName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), attName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetExistingAttsfordoc")]
		public ISingleResult<GetExistingAttsfordocResult> GetExistingAttsfordoc([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> docID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), docID);
			return ((ISingleResult<GetExistingAttsfordocResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertDocument")]
		public int InsertDocument([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TypeID", DbType="Int")] System.Nullable<int> typeID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FileName", DbType="VarChar(50)")] string fileName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Path", DbType="VarChar(50)")] string path)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), typeID, fileName, path);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllWords")]
		public ISingleResult<GetAllWordsResult> GetAllWords()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllWordsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.RelateWords")]
		public int RelateWords([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string relation, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word2, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> isDual)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word1, relation, word2, isDual);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AddSearchNumber")]
		public int AddSearchNumber([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetWordStats")]
		public ISingleResult<GetWordStatsResult> GetWordStats([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string word)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), word);
			return ((ISingleResult<GetWordStatsResult>)(result.ReturnValue));
		}
	}
	
	public partial class GetSearchWordResult
	{
		
		private string _Word;
		
		private int _LineNum;
		
		private int _WordNum;
		
		private string _Value;
		
		public GetSearchWordResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this._Word = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LineNum", DbType="Int NOT NULL")]
		public int LineNum
		{
			get
			{
				return this._LineNum;
			}
			set
			{
				if ((this._LineNum != value))
				{
					this._LineNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WordNum", DbType="Int NOT NULL")]
		public int WordNum
		{
			get
			{
				return this._WordNum;
			}
			set
			{
				if ((this._WordNum != value))
				{
					this._WordNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
	}
	
	public partial class ContextWordsResult
	{
		
		private string _Context;
		
		private System.Nullable<int> _Line;
		
		private System.Nullable<int> _Word_Number;
		
		private string _Document;
		
		public ContextWordsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Context", DbType="VarChar(50)")]
		public string Context
		{
			get
			{
				return this._Context;
			}
			set
			{
				if ((this._Context != value))
				{
					this._Context = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Line", DbType="Int")]
		public System.Nullable<int> Line
		{
			get
			{
				return this._Line;
			}
			set
			{
				if ((this._Line != value))
				{
					this._Line = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Word Number", Storage="_Word_Number", DbType="Int")]
		public System.Nullable<int> Word_Number
		{
			get
			{
				return this._Word_Number;
			}
			set
			{
				if ((this._Word_Number != value))
				{
					this._Word_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Document", DbType="VarChar(50)")]
		public string Document
		{
			get
			{
				return this._Document;
			}
			set
			{
				if ((this._Document != value))
				{
					this._Document = value;
				}
			}
		}
	}
	
	public partial class GetTaggedWordsResult
	{
		
		private string _Word;
		
		private string _TagName;
		
		public GetTaggedWordsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this._Word = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TagName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TagName
		{
			get
			{
				return this._TagName;
			}
			set
			{
				if ((this._TagName != value))
				{
					this._TagName = value;
				}
			}
		}
	}
	
	public partial class GetDocsOfWordResult
	{
		
		private string _value;
		
		public GetDocsOfWordResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this._value = value;
				}
			}
		}
	}
	
	public partial class GetTagsofWordResult
	{
		
		private string _Word;
		
		private string _TagName;
		
		public GetTagsofWordResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this._Word = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TagName", DbType="VarChar(50)")]
		public string TagName
		{
			get
			{
				return this._TagName;
			}
			set
			{
				if ((this._TagName != value))
				{
					this._TagName = value;
				}
			}
		}
	}
	
	public partial class getRelationsOfWordResult
	{
		
		private string _word1;
		
		private string _RelationName;
		
		private string _word2;
		
		public getRelationsOfWordResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_word1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string word1
		{
			get
			{
				return this._word1;
			}
			set
			{
				if ((this._word1 != value))
				{
					this._word1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelationName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string RelationName
		{
			get
			{
				return this._RelationName;
			}
			set
			{
				if ((this._RelationName != value))
				{
					this._RelationName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_word2", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string word2
		{
			get
			{
				return this._word2;
			}
			set
			{
				if ((this._word2 != value))
				{
					this._word2 = value;
				}
			}
		}
	}
	
	public partial class GetExpressionsResult
	{
		
		private string _expression;
		
		public GetExpressionsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expression", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string expression
		{
			get
			{
				return this._expression;
			}
			set
			{
				if ((this._expression != value))
				{
					this._expression = value;
				}
			}
		}
	}
	
	public partial class GetExpressionsOfWordResult
	{
		
		private string _Expression;
		
		public GetExpressionsOfWordResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expression", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Expression
		{
			get
			{
				return this._Expression;
			}
			set
			{
				if ((this._Expression != value))
				{
					this._Expression = value;
				}
			}
		}
	}
	
	public partial class GetDocAttrsResult
	{
		
		private string _AttName;
		
		public GetDocAttrsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AttName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AttName
		{
			get
			{
				return this._AttName;
			}
			set
			{
				if ((this._AttName != value))
				{
					this._AttName = value;
				}
			}
		}
	}
	
	public partial class GetTypeAttsResult
	{
		
		private string _AttName;
		
		private string _Type;
		
		public GetTypeAttsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AttName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string AttName
		{
			get
			{
				return this._AttName;
			}
			set
			{
				if ((this._AttName != value))
				{
					this._AttName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this._Type = value;
				}
			}
		}
	}
	
	public partial class GetExistingAttsfordocResult
	{
		
		private string _Attribute_Name;
		
		private string _Attribute;
		
		public GetExistingAttsfordocResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Attribute Name]", Storage="_Attribute_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Attribute_Name
		{
			get
			{
				return this._Attribute_Name;
			}
			set
			{
				if ((this._Attribute_Name != value))
				{
					this._Attribute_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Attribute", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Attribute
		{
			get
			{
				return this._Attribute;
			}
			set
			{
				if ((this._Attribute != value))
				{
					this._Attribute = value;
				}
			}
		}
	}
	
	public partial class GetAllWordsResult
	{
		
		private string _Word;
		
		private int _LineNum;
		
		private int _WordNum;
		
		private string _Value;
		
		public GetAllWordsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Word", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				if ((this._Word != value))
				{
					this._Word = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LineNum", DbType="Int NOT NULL")]
		public int LineNum
		{
			get
			{
				return this._LineNum;
			}
			set
			{
				if ((this._LineNum != value))
				{
					this._LineNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WordNum", DbType="Int NOT NULL")]
		public int WordNum
		{
			get
			{
				return this._WordNum;
			}
			set
			{
				if ((this._WordNum != value))
				{
					this._WordNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this._Value = value;
				}
			}
		}
	}
	
	public partial class GetWordStatsResult
	{
		
		private int _TotalCount;
		
		private int _SearchNums;
		
		public GetWordStatsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalCount", DbType="Int NOT NULL")]
		public int TotalCount
		{
			get
			{
				return this._TotalCount;
			}
			set
			{
				if ((this._TotalCount != value))
				{
					this._TotalCount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SearchNums", DbType="Int NOT NULL")]
		public int SearchNums
		{
			get
			{
				return this._SearchNums;
			}
			set
			{
				if ((this._SearchNums != value))
				{
					this._SearchNums = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
