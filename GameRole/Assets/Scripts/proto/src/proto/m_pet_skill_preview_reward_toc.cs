namespace proto {
	public class m_pet_skill_preview_reward_toc : Message
	{
		public int err_code = 0;
		public int update_serial = 0;
		public m_pet_skill_preview_reward_toc() {
		}
		public override string getMethodName() {
			return "pet_skill_preview_reward";
		}
		public override string getClassName() {
			return "m_pet_skill_preview_reward_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"update_serial", "int", "null"}};
		}
	}
}
