namespace proto {
	public class m_anima_info_tos : Message
	{
		public double role_id = 0;
		public m_anima_info_tos() {
		}
		public override string getMethodName() {
			return "anima_info";
		}
		public override string getClassName() {
			return "m_anima_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"}};
		}
	}
}
