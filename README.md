
# Segundo-Parcial
# Examen_RentaCar — RentaCar Express

**Estudiante:** Fausto Junior Moreno Santana
**Matrícula:** 2025-1582

---

## Descripción del programa

Aplicación de escritorio hecha en **C# con Windows Forms** para la empresa de alquiler de vehículos *RentaCar Express*. Permite registrar los vehículos que un cliente alquila en un solo formulario, mostrar cada línea del alquiler en una lista y calcular el total a pagar, incluyendo descuento por cliente corporativo, entrega a domicilio e ITBIS.

---

## Datos de entrada

| Dato | Control | Detalle |
|---|---|---|
| Cliente | `txtCliente` | Nombre del cliente |
| Cliente corporativo | `chkCorporativo` | Si está marcado, aplica descuento |
| Fecha de salida | `dtpSalida` | Fecha actual por defecto |
| Vehículo | `txtVehiculo` | Nombre digitado |
| Tarifa por día | `txtTarifa` | Valor digitado (RD$) |
| Días | `nudDias` | De 1 a 30 |
| Seguro | `rbtBasico` / `rbtCompleto` | Básico (por defecto) o Completo (+RD$300 por día) |
| GPS | `chkGps` | +RD$100 por día |
| Entrega | `rbtSucursal` / `rbtDomicilio` | En sucursal (por defecto) o a domicilio (+RD$500, una sola vez) |

---

## Proceso

1. **Load:** deja los controles y resultados en sus valores iniciales y muestra en `lblEncabezado` los títulos *Días, Vehículo, Tarifa y Total*.
2. **Agregar al alquiler** (`btnAgregar`):
   - Tarifa diaria = tarifa digitada + 300 si el seguro es completo + 100 si lleva GPS.
   - Total de línea = tarifa diaria × días.
   - Muestra la línea en columnas con `PadRight`/`PadLeft` (anchos 6, 24, 10 y 12).
   - Acumula el subtotal en una variable `decimal` y reinicia los controles del vehículo.
3. **Calcular total** (`btnCalcular`): si no hay vehículos, muestra un mensaje y no calcula. Si los hay:
   - Descuento = 15 % del subtotal si el cliente es corporativo.
   - Entrega a domicilio = RD$500 una sola vez por alquiler.
   - Base imponible = subtotal − descuento + entrega a domicilio.
   - ITBIS = 18 % de la base imponible.
   - Total = base imponible + ITBIS.
4. **Nuevo alquiler** (`btnLimpiar`): limpia todo, deja el subtotal en cero y pone el foco en `txtCliente`.
5. **Salir** (`btnSalir`): pide confirmación con `MessageBox` (Sí/No) antes de cerrar.

---

## Salida

- **`lstAlquileres`:** una línea por vehículo con días, vehículo (con su seguro/GPS entre paréntesis), tarifa diaria y total de línea.
  Ejemplo: `3     Sedán (Completo)          2,500.00    7,500.00`
- **`lblSubtotal`, `lblDescuento`, `lblDomicilio`, `lblItbis`, `lblTotal`:** resultados con formato `RD$ 0.00`.

### Caso de prueba

Carlos Méndez (corporativo), Sedán con tarifa 2,200, 3 días, seguro completo; Jeepeta con tarifa 3,500, 2 días, con GPS; entrega a domicilio.

| Resultado | Valor |
|---|---|
| Subtotal | RD$ 14,700.00 |
| Descuento | RD$ 2,205.00 |
| Domicilio | RD$ 500.00 |
| ITBIS | RD$ 2,339.10 |
| **Total** | **RD$ 15,334.10** |

<img width="1060" height="557" alt="image" src="https://github.com/user-attachments/assets/bfd86c37-6921-4318-9e85-297f6ff9bd93" />

<img width="1063" height="559" alt="image" src="https://github.com/user-attachments/assets/3efa8260-52c0-47ff-8636-3d24d7a20066" />

<img width="1060" height="562" alt="image" src="https://github.com/user-attachments/assets/6c4972c4-3e0c-436a-980a-e9521fd4ed45" />

<img width="1060" height="557" alt="image" src="https://github.com/user-attachments/assets/abaf960a-347d-4f42-a604-a119c6bbcdac" />



