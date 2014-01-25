namespace proto {
	public class m_mission_deal_special_tos : Message
	{
		public int mission_id = 0;
		public m_mission_deal_special_tos() {
		}
		public override string getMethodName() {
			return "mission_deal_special";
		}
		public override string getClassName() {
			return "m_mission_deal_special_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"mission_id", "int", "null"}};
		}
	}
}
