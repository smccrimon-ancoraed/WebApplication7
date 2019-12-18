using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Film
    {

        [Key]
        public int Film_id { get; set; } // Identity(1,1)
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Release_year { get; set; }  // char[4]
        [Required]
        public byte Language_id { get; set; }
        public byte? Original_language_id { get; set; }
        [Required]
        public byte Rental_duration { get; set; }
        [Required]
        public decimal Rental_rate { get; set; }  // [decimal](4, 2)

        public short? Length { get; set; }
        [Required]
        public decimal Replacement_cost { get; set; } // [decimal](5, 2)

        public string Rating { get; set; } // [varchar] (10)
        public string Special_features { get; set; }
        [Required]
        public DateTime Last_update { get; set; }

        /****** Object:  Table [dbo].[film]   

                USE[sakila]
                GO

        SET ANSI_NULLS ON
        SET QUOTED_IDENTIFIER ON

        CREATE TABLE[dbo].[film]
                (

           [film_id][int] IDENTITY(1,1) NOT NULL,

          [title] [varchar] (255) NOT NULL,

           [description] [text] NULL,
            [release_year] [varchar] (4) NULL,
            [language_id]
                [tinyint]
                NOT NULL,

            [original_language_id] [tinyint] NULL,
            [rental_duration]
                [tinyint]
                NOT NULL,

            [rental_rate] [decimal](4, 2) NOT NULL,

            [length] [smallint] NULL,
            [replacement_cost] [decimal](5, 2) NOT NULL,

            [rating] [varchar] (10) NULL,
            [special_features] [varchar] (255) NULL,
            [last_update]
                [datetime]
                NOT NULL,
        PRIMARY KEY NONCLUSTERED
        (
            [film_id] ASC
        )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
        ) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT(NULL) FOR[description]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT(NULL) FOR[original_language_id]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT((3)) FOR[rental_duration]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT((4.99)) FOR[rental_rate]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT(NULL) FOR[length]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT((19.99)) FOR[replacement_cost]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT('G') FOR[rating]
        GO

        ALTER TABLE[dbo].[film] ADD DEFAULT(NULL) FOR[special_features]
        GO

        ALTER TABLE[dbo].[film] ADD CONSTRAINT[DF_film_last_update]  DEFAULT(getdate()) FOR[last_update]
        GO

        ALTER TABLE[dbo].[film] WITH CHECK ADD CONSTRAINT[fk_film_language] FOREIGN KEY([language_id])
        REFERENCES[dbo].[language]
                ([language_id])
        GO

        ALTER TABLE[dbo].[film]
                CHECK CONSTRAINT[fk_film_language]
        GO

        ALTER TABLE[dbo].[film] WITH CHECK ADD CONSTRAINT[fk_film_language_original] FOREIGN KEY([original_language_id])
        REFERENCES[dbo].[language]
                ([language_id])
        GO

        ALTER TABLE[dbo].[film]
                CHECK CONSTRAINT[fk_film_language_original]
        GO

        ALTER TABLE[dbo].[film] WITH CHECK ADD CONSTRAINT[CHECK_special_features] CHECK(([special_features] IS NULL OR[special_features] like '%Trailers%' OR[special_features] like '%Commentaries%' OR[special_features] like '%Deleted Scenes%' OR[special_features] like '%Behind the Scenes%'))
        GO

        ALTER TABLE[dbo].[film]
                CHECK CONSTRAINT[CHECK_special_features]
        GO

        ALTER TABLE[dbo].[film] WITH CHECK ADD CONSTRAINT[CHECK_special_rating] CHECK(([rating]= 'NC-17' OR[rating]= 'R' OR[rating]= 'PG-13' OR[rating]= 'PG' OR[rating]= 'G'))
        GO

        ALTER TABLE[dbo].[film]
                CHECK CONSTRAINT[CHECK_special_rating]
        GO

        */
    }
}
