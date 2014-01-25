namespace proto {
	public class m_marry_depot_move_toc : Message
	{
		public int err_code = 0;
		public p_couple_goods update = null;
		public p_couple_goods del = null;
		public int op_type = 0;
		public m_marry_depot_move_toc() {
		}
		public override string getMethodName() {
			return "marry_depot_move";
		}
		public override string getClassName() {
			return "m_marry_depot_move_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"update", "p_couple_goods", "null"},new string[] {"del", "p_couple_goods", "null"},new string[] {"op_type", "int", "null"}};
		}
	}
}
