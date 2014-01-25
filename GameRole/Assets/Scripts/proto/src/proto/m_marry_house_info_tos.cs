namespace proto {
	public class m_marry_house_info_tos : Message
	{
		public double role_id = 0;
		public m_marry_house_info_tos() {
		}
		public override string getMethodName() {
			return "marry_house_info";
		}
		public override string getClassName() {
			return "m_marry_house_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"}};
		}
	}
}
