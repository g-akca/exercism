import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

class AppointmentScheduler {
    public LocalDateTime schedule(String appointmentDateDescription) {
        DateTimeFormatter parser = DateTimeFormatter.ofPattern("MM/dd/yyyy HH:mm:ss");
        return LocalDateTime.parse(appointmentDateDescription, parser);
    }

    public boolean hasPassed(LocalDateTime appointmentDate) {
        return appointmentDate.isBefore(LocalDateTime.now());
    }

    public boolean isAfternoonAppointment(LocalDateTime appointmentDate) {
        return appointmentDate.getHour() >= 12 && appointmentDate.getHour() < 18;
    }

    public String getDescription(LocalDateTime appointmentDate) {
        DateTimeFormatter printer = DateTimeFormatter.ofPattern("EEEE, MMMM d, yyyy, 'at' h:mm a");
        return String.format("You have an appointment on %s.", printer.format(appointmentDate));
    }

    public LocalDate getAnniversaryDate() {
        return LocalDate.of(LocalDateTime.now().getYear(), 9, 15);
    }
}
