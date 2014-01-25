namespace proto {
	public class m_pet_fight_toc : Message
	{
		public int err_code = 0;
		public string reason = null;
		public p_pet pet_info = null;
		public p_pet old_fight_pet_info = null;
		public m_pet_fight_toc() {
		}
		public override string getMethodName() {
			return "pet_fight";
		}
		public override string getClassName() {
			return "m_pet_fight_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"reason", "string", "null"},new string[] {"pet_info", "p_pet", "null"},new string[] {"old_fight_pet_info", "p_pet", "null"}};
		}
	}
}
