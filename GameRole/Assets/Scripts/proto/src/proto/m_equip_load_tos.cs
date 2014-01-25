namespace proto {
	public class m_equip_load_tos : Message
	{
		public int equipid = 0;
		public m_equip_load_tos() {
		}
		public override string getMethodName() {
			return "equip_load";
		}
		public override string getClassName() {
			return "m_equip_load_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"equipid", "int", "null"}};
		}
	}
}
