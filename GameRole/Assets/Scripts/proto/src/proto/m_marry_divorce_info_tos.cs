namespace proto {
	public class m_marry_divorce_info_tos : Message
	{
		public double target_id = 0;
		public m_marry_divorce_info_tos() {
		}
		public override string getMethodName() {
			return "marry_divorce_info";
		}
		public override string getClassName() {
			return "m_marry_divorce_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"target_id", "double", "null"}};
		}
	}
}
