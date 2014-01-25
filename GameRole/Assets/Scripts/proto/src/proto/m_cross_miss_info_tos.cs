namespace proto {
	public class m_cross_miss_info_tos : Message
	{
		public int model = 0;
		public m_cross_miss_info_tos() {
		}
		public override string getMethodName() {
			return "cross_miss_info";
		}
		public override string getClassName() {
			return "m_cross_miss_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"model", "int", "null"}};
		}
	}
}
