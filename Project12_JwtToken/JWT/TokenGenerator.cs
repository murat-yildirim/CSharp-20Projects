using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project12_JwtToken.JWT
{
	public class TokenGenerator
	{
		public string GenerateJwtToken(string username, string email, string name, string surname) //OLUŞTURDUĞUMUZ GENERATOR FORMDAN PARAMETRE ALIYORUZ 
		{
			//TOKEN OLUŞTURMA İŞLEMİNDE SECURİTY KEY TANIMLIYORUZ
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234tokenJWT"));//GÖNDERECEĞİMİZ BYTE DİZİSİ BİZİM KEYİMİZİN ÇÖZÜLECEĞİ ANAHTAR OLACAK

			//securityKey ve TOKEN OLUŞTURURKEN KULLANACAĞIMIZ ŞİFRELEME ALGORİTMASINI TUTUYOR
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			//BU DİZİ ÖĞESİ TOKENIN TEMEL PARAMETRELERİNİ TUTUYOR
			var claimsExample = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub,username),
				new Claim(JwtRegisteredClaimNames.Email,email),
				new Claim(JwtRegisteredClaimNames.GivenName,name),
				new Claim(JwtRegisteredClaimNames.FamilyName,surname),

				new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
			};

			// YAYINCI,DİNLEYİCİ ,PARAMETLER GELİŞ YERİ ,ŞİFRELEME ALGORİTMASINI ,TOKEN SÜRESİNİ TUTUYOR
			var token = new JwtSecurityToken(
				issuer: "localhost", // KİM TARAFINDA OLUŞTURULDU - YAYINLAYICI 
				audience: "localhost", // KİM TARAFINDAN DİNLENİYOR - DİNLEYİCİ
				claims: claimsExample, // claimsExample GELEN PARAMETRELER
				expires: DateTime.Now.AddMinutes(5), // TOKENIN GEÇERLİLİK SÜRESİ
				signingCredentials: credentials // TOKENIN SECURİTY KEY VE ALGORİTMASINI TUTUYOR
				);

			return new JwtSecurityTokenHandler().WriteToken(token);

		}

		public string GenerateJwtToken2(string username)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20Derste20ProjeToken+-*/1234tokenJWT"));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			var claimsExample = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub,username),
				new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
			};

			var token = new JwtSecurityToken(
				issuer: "localhost", // KİM TARAFINDA OLUŞTURULDU - YAYINLAYICI 
				audience: "localhost", // KİM TARAFINDAN DİNLENİYOR - DİNLEYİCİ
				claims: claimsExample, // claimsExample GELEN PARAMETRELER
				expires: DateTime.Now.AddMinutes(5), // TOKENIN GEÇERLİLİK SÜRESİ
				signingCredentials: credentials // TOKENIN SECURİTY KEY VE ALGORİTMASINI TUTUYOR
				);
			return new JwtSecurityTokenHandler().WriteToken(token);

		}



	}
}
