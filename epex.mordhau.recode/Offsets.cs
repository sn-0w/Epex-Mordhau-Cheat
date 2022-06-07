using System;

namespace epex.mordhau.recode
{
	// Token: 0x0200000A RID: 10
	internal class Offsets
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00002566 File Offset: 0x00000766
		public Offsets()
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		// Note: this type is marked as 'beforefieldinit'.
		static Offsets()
		{
		}

		// Token: 0x040000AA RID: 170
		private const string GEngine = "base+58C84E8";

		// Token: 0x040000AB RID: 171
		private const string UWorld = "base+58CBEE0";

		// Token: 0x040000AC RID: 172
		public static string PlayerController = "base+58C84E8,DF8,38,0,30";

		// Token: 0x040000AD RID: 173
		public static string MordhauCamera = "base+58C84E8,DF8,38,0,30,2B0,220,250,B58";

		// Token: 0x040000AE RID: 174
		public static string GameState = "base+58CBEE0,120";

		// Token: 0x040000AF RID: 175
		public static string PlayerArray = Offsets.GameState + ",238";

		// Token: 0x040000B0 RID: 176
		public static string PlayerSizeOffset = Offsets.GameState + ",240";

		// Token: 0x040000B1 RID: 177
		public static string ParryR = "base+58C84E8,DF8,38,0,30,260,11D8,1A0C";

		// Token: 0x040000B2 RID: 178
		public static string RightHand = "base+58C84E8,DF8,38,0,30,260,11D8";

		// Token: 0x040000B3 RID: 179
		public static string LeftHand = "base+58C84E8,DF8,38,0,30,260,11E0";

		// Token: 0x040000B4 RID: 180
		public static string ParryL = "base+58C84E8,DF8,38,0,30,260,11E0,1A0C";

		// Token: 0x040000B5 RID: 181
		public static string TurnCap1 = "base+58C84E8,DF8,38,0,30,260,8C4";

		// Token: 0x040000B6 RID: 182
		public static string TurnCap2 = "base+58C84E8,DF8,38,0,30,260,8C8";

		// Token: 0x040000B7 RID: 183
		public static string TurnCap3 = "base+58C84E8,DF8,38,0,30,260,8CC";

		// Token: 0x040000B8 RID: 184
		public static string TurnCap4 = "base+58C84E8,DF8,38,0,30,260,8D0";

		// Token: 0x040000B9 RID: 185
		public static string ThirdpersonX = "base+58C84E8,DF8,38,0,30,260,240,280,B58,830";

		// Token: 0x040000BA RID: 186
		public static string bCanDodge = "base+58C84E8,DF8,38,0,30,260,E46";

		// Token: 0x040000BB RID: 187
		public static string DodgeDuration = "base+58C84E8,DF8,38,0,30,260,E84";

		// Token: 0x040000BC RID: 188
		public static string DodgeCooldown = "base+58C84E8,DF8,38,0,30,260,E88";

		// Token: 0x040000BD RID: 189
		public static string DodgeCost = "base+58C84E8,DF8,38,0,30,260,E8C";

		// Token: 0x040000BE RID: 190
		public static string DodgeCanceled = "base+58C84E8,DF8,38,0,30,260,E90";

		// Token: 0x040000BF RID: 191
		public static string CustomFov = "base+58C84E8,DF8,38,0,30,2B8,23C";

		// Token: 0x040000C0 RID: 192
		public static string IngameFov = "base+58C84E8,DF8,38,0,30,2B8,238";

		// Token: 0x040000C1 RID: 193
		public static string StabCombo = "base+58C84E8,DF8,38,0,30,260,11D8,0F40";

		// Token: 0x040000C2 RID: 194
		public static string StabCombo1 = "base+58C84E8,DF8,38,0,30,260,11D8,0F41";

		// Token: 0x040000C3 RID: 195
		public static string StabCombo2 = "base+58C84E8,DF8,38,0,30,260,11D8,1068";

		// Token: 0x040000C4 RID: 196
		public static string StabCombo3 = "base+58C84E8,DF8,38,0,30,260,11D8,1069";

		// Token: 0x040000C5 RID: 197
		public static string StrikeCombo = "base+58C84E8,DF8,38,0,30,260,11D8,13E0";

		// Token: 0x040000C6 RID: 198
		public static string StrikeCombo1 = "base+58C84E8,DF8,38,0,30,260,11D8,13E1";

		// Token: 0x040000C7 RID: 199
		public static string StrikeCombo2 = "base+58C84E8,DF8,38,0,30,260,11D8,1508";

		// Token: 0x040000C8 RID: 200
		public static string StrikeCombo3 = "base+58C84E8,DF8,38,0,30,260,11D8,1509";

		// Token: 0x040000C9 RID: 201
		public static string StabFlinch = "base+58C84E8,DF8,38,0,30,260,11D8,0F43";

		// Token: 0x040000CA RID: 202
		public static string StabFlinch1 = "base+58C84E8,DF8,38,0,30,260,11D8,0F44";

		// Token: 0x040000CB RID: 203
		public static string StabFlinch2 = "base+58C84E8,DF8,38,0,30,260,11D8,106B";

		// Token: 0x040000CC RID: 204
		public static string StabFlinch3 = "base+58C84E8,DF8,38,0,30,260,11D8,106C";

		// Token: 0x040000CD RID: 205
		public static string StrikeFlinch = "base+58C84E8,DF8,38,0,30,260,11D8,13E3";

		// Token: 0x040000CE RID: 206
		public static string StrikeFlinch1 = "base+58C84E8,DF8,38,0,30,260,11D8,13E4";

		// Token: 0x040000CF RID: 207
		public static string StrikeFlinch2 = "base+58C84E8,DF8,38,0,30,260,11D8,150B";

		// Token: 0x040000D0 RID: 208
		public static string StrikeFlinch3 = "base+58C84E8,DF8,38,0,30,260,11D8,150C";

		// Token: 0x040000D1 RID: 209
		public static string Pawn = Offsets.PlayerArray + ",0,368";

		// Token: 0x040000D2 RID: 210
		public static string MovRes = "base+58C84E8,DF8,38,0,30,260,AE8,61";

		// Token: 0x040000D3 RID: 211
		public static string SuperSprint = "base+58C84E8,DF8,38,0,30,260,288,D1C";

		// Token: 0x040000D4 RID: 212
		public static string AntiAFK = "base+58C84E8,DF8,38,0,30,A20";

		// Token: 0x040000D5 RID: 213
		public static string Rdrawtime = Offsets.RightHand + ",CEC";

		// Token: 0x040000D6 RID: 214
		public static string Rcanceltime = Offsets.RightHand + ",CF0";

		// Token: 0x040000D7 RID: 215
		public static string Rreleasetime = Offsets.RightHand + ",CF4";

		// Token: 0x040000D8 RID: 216
		public static string Rreloadanim = Offsets.RightHand + ",A80";

		// Token: 0x040000D9 RID: 217
		public static string Ldrawtime = Offsets.LeftHand + ",CEC";

		// Token: 0x040000DA RID: 218
		public static string Lcanceltime = Offsets.LeftHand + ",CF0";

		// Token: 0x040000DB RID: 219
		public static string Lreleasetime = Offsets.LeftHand + ",CF4";

		// Token: 0x040000DC RID: 220
		public static string Lmaxhold = Offsets.LeftHand + ",CC8";

		// Token: 0x040000DD RID: 221
		public static string Ltrembl = Offsets.LeftHand + ",5A8";

		// Token: 0x040000DE RID: 222
		public static string Lsway = Offsets.LeftHand + ",580";

		// Token: 0x040000DF RID: 223
		public static string addforward = "base+58C84E8,DF8,38,0,30,260,899";

		// Token: 0x040000E0 RID: 224
		public static string turnlimit = "base+58C84E8,DF8,38,0,30,260,8A8";

		// Token: 0x040000E1 RID: 225
		public static string addright = "base+58C84E8,DF8,38,0,30,260,89A";

		// Token: 0x040000E2 RID: 226
		public static string playerstate = "base+58C84E8,DF8,38,0,30,260,240";

		// Token: 0x040000E3 RID: 227
		public static string playfab = Offsets.playerstate + ",3A8,0";

		// Token: 0x040000E4 RID: 228
		public static string lookupvalue = "base+58C84E8,DF8,38,0,30,260,520";

		// Token: 0x040000E5 RID: 229
		public static string turnvalue = "base+58C84E8,DF8,38,0,30,260,520";

		// Token: 0x040000E6 RID: 230
		public static string motion = "base+58C84E8,DF8,38,0,30,260,AE8";

		// Token: 0x040000E7 RID: 231
		public static string endtime = Offsets.motion + ",50";

		// Token: 0x040000E8 RID: 232
		public static string movewarmup = Offsets.GameState + ",689";

		// Token: 0x040000E9 RID: 233
		public static string lastwoosh = "11D8,0D38";

		// Token: 0x040000EA RID: 234
		public static string wantsblock = "base+58C84E8,DF8,38,0,30,260,1009";

		// Token: 0x040000EB RID: 235
		public static string player_x = "288,250";

		// Token: 0x040000EC RID: 236
		public static string player_y = "288,254";

		// Token: 0x040000ED RID: 237
		public static string player_z = "288,258";

		// Token: 0x040000EE RID: 238
		public static string good_yaw = "base+058B4280,30,28C";

		// Token: 0x040000EF RID: 239
		public static string lastvoice = "base+58C84E8,DF8,38,0,30,260,6A0,C8";

		// Token: 0x040000F0 RID: 240
		public static string voicequeue = "base+58C84E8,DF8,38,0,30,260,6A0,EC";

		// Token: 0x040000F1 RID: 241
		public static string cam_pitch = Offsets.MordhauCamera + ",128";

		// Token: 0x040000F2 RID: 242
		public static string cam_yaw = Offsets.MordhauCamera + ",12C";

		// Token: 0x040000F3 RID: 243
		public static string cam_x = Offsets.MordhauCamera + ",11C";

		// Token: 0x040000F4 RID: 244
		public static string cam_y = Offsets.MordhauCamera + ",120";

		// Token: 0x040000F5 RID: 245
		public static string cam_z = Offsets.MordhauCamera + ",124";

		// Token: 0x040000F6 RID: 246
		public const string sessiontoken = "base+056C28F8,0";
	}
}
