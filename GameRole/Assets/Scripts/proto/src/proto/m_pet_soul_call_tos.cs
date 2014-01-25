namespace proto {
	public class m_pet_soul_call_tos : Message
	{
		public int npc_id = 0;
		public m_pet_soul_call_tos() {
		}
		public override string getMethodName() {
			return "pet_soul_call";
		}
		public override string getClassName() {
			return "m_pet_soul_call_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"npc_id", "int", "null"}};
		}
	}
}
