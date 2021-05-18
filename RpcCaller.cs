using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace GrpcHang
{
    public class RpcCaller
    {
        public async Task MakeCalls()
        {
            var channel = new Channel("localhost", 10000, ChannelCredentials.Insecure);
            var callInvoker = new DefaultCallInvoker(channel);
            var client = new Test.TestClient(callInvoker);

            try { await client.Call0Async(new Request0()); } catch {}
            try { await client.Call1Async(new Request1()); } catch {}
            try { await client.Call2Async(new Request2()); } catch {}
            try { await client.Call3Async(new Request3()); } catch {}
            try { await client.Call4Async(new Request4()); } catch {}
            try { await client.Call5Async(new Request5()); } catch {}
            try { await client.Call6Async(new Request6()); } catch {}
            try { await client.Call7Async(new Request7()); } catch {}
            try { await client.Call8Async(new Request8()); } catch {}
            try { await client.Call9Async(new Request9()); } catch {}
            try { await client.Call10Async(new Request10()); } catch {}
            try { await client.Call11Async(new Request11()); } catch {}
            try { await client.Call12Async(new Request12()); } catch {}
            try { await client.Call13Async(new Request13()); } catch {}
            try { await client.Call14Async(new Request14()); } catch {}
            try { await client.Call15Async(new Request15()); } catch {}
            try { await client.Call16Async(new Request16()); } catch {}
            try { await client.Call17Async(new Request17()); } catch {}
            try { await client.Call18Async(new Request18()); } catch {}
            try { await client.Call19Async(new Request19()); } catch {}
            try { await client.Call20Async(new Request20()); } catch {}
            try { await client.Call21Async(new Request21()); } catch {}
            try { await client.Call22Async(new Request22()); } catch {}
            try { await client.Call23Async(new Request23()); } catch {}
            try { await client.Call24Async(new Request24()); } catch {}
            try { await client.Call25Async(new Request25()); } catch {}
            try { await client.Call26Async(new Request26()); } catch {}
            try { await client.Call27Async(new Request27()); } catch {}
            try { await client.Call28Async(new Request28()); } catch {}
            try { await client.Call29Async(new Request29()); } catch {}
            try { await client.Call30Async(new Request30()); } catch {}
            try { await client.Call31Async(new Request31()); } catch {}
            try { await client.Call32Async(new Request32()); } catch {}
            try { await client.Call33Async(new Request33()); } catch {}
            try { await client.Call34Async(new Request34()); } catch {}
            try { await client.Call35Async(new Request35()); } catch {}
            try { await client.Call36Async(new Request36()); } catch {}
            try { await client.Call37Async(new Request37()); } catch {}
            try { await client.Call38Async(new Request38()); } catch {}
            try { await client.Call39Async(new Request39()); } catch {}
            try { await client.Call40Async(new Request40()); } catch {}
            try { await client.Call41Async(new Request41()); } catch {}
            try { await client.Call42Async(new Request42()); } catch {}
            try { await client.Call43Async(new Request43()); } catch {}
            try { await client.Call44Async(new Request44()); } catch {}
            try { await client.Call45Async(new Request45()); } catch {}
            try { await client.Call46Async(new Request46()); } catch {}
            try { await client.Call47Async(new Request47()); } catch {}
            try { await client.Call48Async(new Request48()); } catch {}
            try { await client.Call49Async(new Request49()); } catch {}
            try { await client.Call50Async(new Request50()); } catch {}
            try { await client.Call51Async(new Request51()); } catch {}
            try { await client.Call52Async(new Request52()); } catch {}
            try { await client.Call53Async(new Request53()); } catch {}
            try { await client.Call54Async(new Request54()); } catch {}
            try { await client.Call55Async(new Request55()); } catch {}
            try { await client.Call56Async(new Request56()); } catch {}
            try { await client.Call57Async(new Request57()); } catch {}
            try { await client.Call58Async(new Request58()); } catch {}
            try { await client.Call59Async(new Request59()); } catch {}
            try { await client.Call60Async(new Request60()); } catch {}
            try { await client.Call61Async(new Request61()); } catch {}
            try { await client.Call62Async(new Request62()); } catch {}
            try { await client.Call63Async(new Request63()); } catch {}
            try { await client.Call64Async(new Request64()); } catch {}
            try { await client.Call65Async(new Request65()); } catch {}
            try { await client.Call66Async(new Request66()); } catch {}
            try { await client.Call67Async(new Request67()); } catch {}
            try { await client.Call68Async(new Request68()); } catch {}
            try { await client.Call69Async(new Request69()); } catch {}
            try { await client.Call70Async(new Request70()); } catch {}
            try { await client.Call71Async(new Request71()); } catch {}
            try { await client.Call72Async(new Request72()); } catch {}
            try { await client.Call73Async(new Request73()); } catch {}
            try { await client.Call74Async(new Request74()); } catch {}
            try { await client.Call75Async(new Request75()); } catch {}
            try { await client.Call76Async(new Request76()); } catch {}
            try { await client.Call77Async(new Request77()); } catch {}
            try { await client.Call78Async(new Request78()); } catch {}
            try { await client.Call79Async(new Request79()); } catch {}
            try { await client.Call80Async(new Request80()); } catch {}
            try { await client.Call81Async(new Request81()); } catch {}
            try { await client.Call82Async(new Request82()); } catch {}
            try { await client.Call83Async(new Request83()); } catch {}
            try { await client.Call84Async(new Request84()); } catch {}
            try { await client.Call85Async(new Request85()); } catch {}
            try { await client.Call86Async(new Request86()); } catch {}
            try { await client.Call87Async(new Request87()); } catch {}
            try { await client.Call88Async(new Request88()); } catch {}
            try { await client.Call89Async(new Request89()); } catch {}
            try { await client.Call90Async(new Request90()); } catch {}
            try { await client.Call91Async(new Request91()); } catch {}
            try { await client.Call92Async(new Request92()); } catch {}
            try { await client.Call93Async(new Request93()); } catch {}
            try { await client.Call94Async(new Request94()); } catch {}
            try { await client.Call95Async(new Request95()); } catch {}
            try { await client.Call96Async(new Request96()); } catch {}
            try { await client.Call97Async(new Request97()); } catch {}
            try { await client.Call98Async(new Request98()); } catch {}
            try { await client.Call99Async(new Request99()); } catch {}

        }
    }
}