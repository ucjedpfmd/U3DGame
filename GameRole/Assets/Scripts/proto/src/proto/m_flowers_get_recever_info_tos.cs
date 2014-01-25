namespace proto {
	public class m_flowers_get_recever_info_tos : Message
	{
		public string role_name = null;
		public m_flowers_get_recever_info_tos() {
		}
		public override string getMethodName() {
			return "flowers_get_recever_info";
		}
		public override string getClassName() {
			return "m_flowers_get_recever_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_name", "string", "null"}};
		}
	}
}
