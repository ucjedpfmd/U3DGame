namespace proto {
	public class m_achievement_award_onekey_tos : Message
	{
		public int group_type = 0;
		public int gold_bind = 0;
		public int item_ids = 0;
		public int formula = 0;
		public int title = 0;
		public m_achievement_award_onekey_tos() {
		}
		public override string getMethodName() {
			return "achievement_award_onekey";
		}
		public override string getClassName() {
			return "m_achievement_award_onekey_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"group_type", "int", "null"},new string[] {"gold_bind", "int", "null"},new string[] {"item_ids", "int", "null"},new string[] {"formula", "int", "null"},new string[] {"title", "int", "null"}};
		}
	}
}
