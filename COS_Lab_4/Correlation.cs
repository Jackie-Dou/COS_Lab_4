using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace COS_Lab_4
{
    public class Correlation
    {
        public static Complex[] CrossCorrelation(double[] signal1, double[] signal2)
        {
            if (signal1.Length != signal2.Length)
            {
                throw new ArgumentException("The lengths of arrays must be the same");
            }

            int L = signal1.Length + signal2.Length;

            Complex[] correlation = new Complex[L];

            int index1 = 0;
            int index2 = signal2.Length - 1;

            int start;
            int end;
            int index;

            for (int i = 0; i < L; i++)
            {
                Complex sum = 0;

                if (i < signal1.Length - 1)
                {
                    start = index2;
                    end = signal2.Length;
                    index = 0;

                    for (int j = start; j < end; j++)
                    {
                        sum += signal1[index++] * signal2[j];
                    }

                    index1++;
                    index2--;
                }
                else
                {
                    start = signal1.Length - index1 - 1;
                    end = signal1.Length;
                    index = 0;

                    for (int j = start; j < end; j++)
                    {
                        sum += signal1[j] * signal2[index++];
                    }

                    index1--;
                    index2++;
                }

                correlation[i] = sum;
            }

            return Normalize(correlation);
        }

        public static Complex[] FastCrossCorrelation(double[] signal1, double[] signal2)
        {
            int L = signal1.Length + signal2.Length;

            Complex[] complexSignal1 = new Complex[L];
            Complex[] complexSignal2 = new Complex[L];

            for (int i = 0; i < signal1.Length; i++)
            {
                complexSignal1[i] = signal1[i];
            }

            for (int i = 0; i < signal2.Length; i++)
            {
                complexSignal2[i] = signal2[i];
            }

            Complex[] bpf1 = DecimationInTime(complexSignal1, true);
            Complex[] bpf2 = DecimationInTime(complexSignal2, true);

            Complex[] multiplicated = new Complex[L];
            for (int i = 0; i < L; i++)
            {
                bpf1[i] /= bpf1.Length;
                bpf2[i] /= bpf2.Length;
                multiplicated[i] = bpf1[i] * Complex.Conjugate(bpf2[i]);
            }

            Complex[] correlation = DecimationInTime(multiplicated, false);

            for (int i = 0; i < correlation.Length / 2; i++)
            {
                Complex temp = correlation[i];
                correlation[i] = correlation[correlation.Length / 2 + i];
                correlation[correlation.Length / 2 + i] = temp;
            }

            return Normalize(correlation);
        }

        private static Complex[] Normalize(Complex[] values)
        {
            Complex[] result = new Complex[values.Length];

            double max = values.Max(c => Math.Abs(c.Real));

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = values[i] / max;
            }

            return result;
        }

        public static double[] GetShiftedSignal(double[] signal, int shift)
        {
            double[] shiftedSignal = new double[signal.Length];

            for (int i = 0; i < shiftedSignal.Length; i++)
            {
                int index = i - shift;
                if (index < 0)
                {
                    index = signal.Length + index;
                }
                shiftedSignal[i] = signal[index];
            }
            return shiftedSignal;
        }

        public static Complex[] DecimationInTime(Complex[] frame, bool direct)
        {
            if (frame.Length == 1) return frame;
            int frameHalfSize = frame.Length >> 1;   // frame.Length/2
            int frameFullSize = frame.Length;

            Complex[] frameOdd = new Complex[frameHalfSize];
            Complex[] frameEven = new Complex[frameHalfSize];
            for (int i = 0; i < frameHalfSize; i++)
            {
                int j = i << 1;               // i = 2*j;
                frameOdd[i] = frame[j + 1];
                frameEven[i] = frame[j];
            }

            Complex[] spectrumOdd = DecimationInTime(frameOdd, direct);
            Complex[] spectrumEven = DecimationInTime(frameEven, direct);

            double arg = direct
                ? -(2 * Math.PI) / frameFullSize
                : (2 * Math.PI) / frameFullSize;
            Complex omegaPowBase = new Complex(Math.Cos(arg), Math.Sin(arg));
            Complex omega = Complex.One;
            Complex[] spectrum = new Complex[frameFullSize];

            for (int j = 0; j < frameHalfSize; j++)
            {
                spectrum[j] = spectrumEven[j] + omega * spectrumOdd[j];
                spectrum[j + frameHalfSize] = spectrumEven[j] - omega * spectrumOdd[j];
                omega *= omegaPowBase;
            }

            return spectrum;
        }
    }
}
