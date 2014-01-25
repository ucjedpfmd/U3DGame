namespace proto {
	public class m_cut_soul_hand_mission_toc : Message
	{
		public int err_code = 0;
		public m_cut_soul_hand_mission_toc() {
		}
		public override string getMethodName() {
			return "cut_soul_hand_mission";
		}
		public override string getClassName() {
			return "m_cut_soul_hand_mission_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
