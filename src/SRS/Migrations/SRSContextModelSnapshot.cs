using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using SRS.Models.Tables;

namespace SRS.Migrations
{
    [ContextType(typeof(SRSContext))]
    partial class SRSContextModelSnapshot : ModelSnapshot
    {
        public override void BuildModel(ModelBuilder builder)
        {
            builder
                .Annotation("SqlServer:DefaultSequenceName", "DefaultSequence")
                .Annotation("SqlServer:Sequence:.DefaultSequence", "'DefaultSequence', '', '1', '10', '', '', 'Int64', 'False'")
                .Annotation("SqlServer:ValueGeneration", "Sequence");
            
            builder.Entity("SRS.Models.Conjugation", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("english");
                    
                    b.Property<string>("hangeul");
                    
                    b.Property<string>("politeness");
                    
                    b.Property<string>("tense");
                    
                    b.Property<int?>("wordid");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.History", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<DateTime>("created");
                    
                    b.Property<string>("createdby");
                    
                    b.Property<string>("operation");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.Level", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("name");
                    
                    b.Property<int>("nextdays");
                    
                    b.Property<int>("nexthours");
                    
                    b.Property<int>("nextminutes");
                    
                    b.Property<int>("nextmonths");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.Review", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<bool>("pass");
                    
                    b.Property<DateTime>("time");
                    
                    b.Property<int?>("wordid");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.Sentence", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("english");
                    
                    b.Property<string>("hangeul");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.Tables.Queue", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<int>("level");
                    
                    b.Property<DateTime>("nextreview");
                    
                    b.Property<int?>("userid");
                    
                    b.Property<int?>("wordid");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.Tables.User", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<DateTime>("lastreview");
                    
                    b.Property<int>("level");
                    
                    b.Property<string>("username");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.Word", b =>
                {
                    b.Property<int>("id")
                        .GenerateValueOnAdd()
                        .StoreGeneratedPattern(StoreGeneratedPattern.Identity);
                    
                    b.Property<string>("definition");
                    
                    b.Property<string>("english");
                    
                    b.Property<string>("hangeul");
                    
                    b.Key("id");
                });
            
            builder.Entity("SRS.Models.Conjugation", b =>
                {
                    b.Reference("SRS.Models.Word")
                        .InverseCollection()
                        .ForeignKey("wordid");
                });
            
            builder.Entity("SRS.Models.Review", b =>
                {
                    b.Reference("SRS.Models.Word")
                        .InverseCollection()
                        .ForeignKey("wordid");
                });
            
            builder.Entity("SRS.Models.Tables.Queue", b =>
                {
                    b.Reference("SRS.Models.Tables.User")
                        .InverseCollection()
                        .ForeignKey("userid");
                    
                    b.Reference("SRS.Models.Word")
                        .InverseCollection()
                        .ForeignKey("wordid");
                });
        }
    }
}
