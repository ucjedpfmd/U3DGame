namespace proto {
	public class m_family_info_mod_tos : Message
	{
		public int op_type = 0;
		public string param = null;
		public m_family_info_mod_tos() {
		}
		public override string getMethodName() {
			return "family_info_mod";
		}
		public override string getClassName() {
			return "m_family_info_mod_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"param", "string", "null"}};
		}
	}
}
