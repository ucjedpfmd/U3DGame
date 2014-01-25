namespace proto {
	public class m_special_activity_detail_tos : Message
	{
		public int activity_key = 0;
		public m_special_activity_detail_tos() {
		}
		public override string getMethodName() {
			return "special_activity_detail";
		}
		public override string getClassName() {
			return "m_special_activity_detail_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"activity_key", "int", "null"}};
		}
	}
}
